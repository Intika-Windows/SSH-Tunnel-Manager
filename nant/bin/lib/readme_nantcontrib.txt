Файлы в этой директории [CollectionGen.dll Interop.MsmMergeTypeLib.dll Interop.StarTeam.dll Interop.WindowsInstaller.dll 
SourceSafe.Interop.dll] должны быть в поддиректории net, так как они platform specific, 
но в ней их не видит nant. Решение - не пихать в поддиректорию (как сейчас) или зарегить сборки в gac.