// Developer Express Code Central Example:
// Topological Sorting example
// 
// This example demonstrates the implementation of an algorithm for topological
// sorting that is used in our library. It is a console application. The result
// screen is shown below:
// 
// <image id="86a33c52-a042-44aa-8cc3-6151fa3c31cf"
// name="topologicalsort-console.png" />
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3121

using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Utils.Implementation;

namespace DevExpress.Utils {
    public static class Algorithms {
        public static IList<T> TopologicalSort<T>(IList<T> sourceObjects, IComparer<T> comparer) {
            TopologicalSorter<T> sorter = new TopologicalSorter<T>();
            return sorter.Sort(sourceObjects, comparer);
        }
    }
}

namespace DevExpress.Utils.Implementation {
    #region TopologicalSorter
public class TopologicalSorter<T> {
    #region Node
    public class Node {
        int refCount;
        Node next;
        public Node(int refCount, Node next) {
            this.refCount = refCount;
            this.next = next;
        }
        public int RefCount { get { return refCount; } }
        public Node Next { get { return next; } }
    }
    #endregion

    #region Fields
    int[] qLink;
    Node[] nodes;
    IList<T> sourceObjects; 
    IComparer<T> comparer;
    #endregion

    #region Properties
    protected internal Node[] Nodes { get { return nodes; } }
    protected internal int[] QLink { get { return qLink; } }
    protected IComparer<T> Comparer { get { return comparer; } }
    protected internal IList<T> SourceObjects { get { return sourceObjects; } }
    #endregion

    protected IComparer<T> GetComparer() {
        return Comparer ?? Comparer<T>.Default;
    }
    protected bool IsDependOn(T x, T y) {
        return GetComparer().Compare(x, y) > 0;
    }
    public IList<T> Sort(IList<T> sourceObjects, IComparer<T> comparer) {
        this.comparer = comparer;
        return Sort(sourceObjects);
    }
    public IList<T> Sort(IList<T> sourceObjects) {
        this.sourceObjects = sourceObjects;

        int n = sourceObjects.Count;
        if (n < 2)
            return sourceObjects;

        Initialize(n);
        CalculateRelations(sourceObjects);

        int r = FindNonRelatedNodeIndex();
        IList<T> result = ProcessNodes(r);
        return result.Count > 0 ? result : sourceObjects;

    }
    protected internal void Initialize(int n) {
        int count = n + 1;
        this.qLink = new int[count];
        this.nodes = new Node[count];
    }
    protected internal void CalculateRelations(IList<T> sourceObjects) {
        int n = sourceObjects.Count;
        for (int y = 0; y < n; y++) {
            for (int x = 0; x < n; x++) {
                if (!IsDependOn(sourceObjects[y], sourceObjects[x]))
                    continue;
                int minIndex = x + 1;
                int maxIndex = y + 1;
                QLink[maxIndex]++;
                Nodes[minIndex] = new Node(maxIndex, Nodes[minIndex]);
            }
        }
    }
    protected internal int FindNonRelatedNodeIndex() {
        int r = 0;
        int n = SourceObjects.Count;
        for (int i = 0; i <= n; i++) {
            if (QLink[i] == 0) {
                QLink[r] = i;
                r = i;
            }
        }
        return r;
    }
    protected virtual IList<T> ProcessNodes(int r) {
        int n = sourceObjects.Count;
        int k = n;

        int f = QLink[0];
        List<T> result = new List<T>(n);
        while (f > 0) {
            result.Add(sourceObjects[f - 1]);
            k--;

            Node node = Nodes[f];
            while (node != null) {
                node = RemoveRelation(node, ref r);
            }
            f = QLink[f];
        }
        //Debug.Assert(k == 0);
        return result;

    }
    Node RemoveRelation(Node node, ref int r) {
        int suc_p = node.RefCount;
        QLink[suc_p]--;

        if (QLink[suc_p] == 0) {
            QLink[r] = suc_p;
            r = suc_p;
        }
        return node.Next;
    }
}
#endregion
}
