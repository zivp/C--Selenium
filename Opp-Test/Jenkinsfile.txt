pipeline {
    agent any
    triggers {
        githubPush()
    }
    stages {
        stage('Restore packages'){
           steps{
               sh 'dotnet restore Opp-Test.sln'
            }
         }
        stage('Clean'){
           steps{
               sh 'dotnet clean Opp-Test.sln --configuration Release'
            }
         }
        stage('Build'){
           steps{
               sh 'dotnet build Opp-Test.sln --configuration Release --no-restore'
            }
         }
        stage('Test: Unit Test'){
           steps {
                sh 'dotnet test Opp-Test/Opp-Test.csproj --configuration Release --no-restore'
             }
          }
      
        }
    }
