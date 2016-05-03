del *.nupkg

nuget pack ..\Build.Mvc\Build.Mvc.csproj -Prop Configuration=Release -IncludeReferencedProjects
REM nuget push *.nupkg
