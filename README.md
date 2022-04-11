# Regular Expressions in DotNet </br>
## This project has been developed using Linux Ubuntu and VS Code </br>
# What's new in this branch ? :new:
> Created a new Unit Test project

> Steps Used are as follows :

1. Create a new solution for current project
> * dotnet new sln

2. Create a new mstest project
> * dotnet new mstest -o <give_the_name_for_test_project>

3. Add Test Project to the solution
> * dotnet add (test_projct_name)/(test_projct_name.csproj) reference (your_Current_project_name)/(your_Current_project_name.csproj)

4. Run the Tests
> * dotnet test (test_projct_name)/(test_projct_name.csproj)