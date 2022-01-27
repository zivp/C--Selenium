pipeline {
    agent any
    triggers {
        githubPush()
    }
    stages {
        stage('Restore packages'){
           steps{
               bat 'dotnet restore Opp-Test.sln'
            }
         }
        stage('Clean'){
           steps{
               bat 'dotnet clean Opp-Test.sln --configuration Release'
            }
         }
        stage('Build'){
           steps{
               bat 'dotnet build Opp-Test.sln --configuration Release --no-restore'
            }
         }
        stage('Test: Unit Test'){
           steps {
                bat 'dotnet test Opp-Test/Opp-Test.csproj --configuration Release --no-restore'
             }
          }
      
        }
    }
