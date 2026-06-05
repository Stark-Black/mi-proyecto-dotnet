pipeline{
    agent any
    enviroment{
        DOTNET_VERSION = '6.0'
    }
    stages{
        stage('Clonar Repositorio'){
            steps{
                git 'https://github.com/Stark-Black/mi-proyecto-dotnet.git'
            }
        }

        stage('Restuarar Dependencias'){
            steps{
                sh 'dotnet restore'
            }

        }

        stage('Compilar proyecto'){
            steps{
                sh 'dotnet build -- configuration Release'
            }
        }
        stage('Ejecutar pruebas'){
            steps{
                sh 'dotnet test'
            }
        }

        stage('Publicar Aplicaion'){
            steps{
                sh 'dotnet publish --c Release -o output'
            }
        }

    }
    
}
