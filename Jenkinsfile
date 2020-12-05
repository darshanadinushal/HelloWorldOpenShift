//SCRIPTED

//DECLARATIVE
pipeline {
	agent any
	
	environment {
		dockerHome = tool 'myDocker'
		PATH = "$dockerHome/bin:$PATH"
	}


	stages {
		stage('Build') {
			steps {
			
			  echo "PATH - $PATH"
			   echo 'mvn --version'
			   sh 'docker version'
			}
		}
		stage('Test') {
			steps {
				echo 'Test'
			}
		}

		
		stage('Integration Test') {
			steps {
				echo 'Integration Test'
			}
		}

		stage('Package') {
			steps {
				
				echo 'DskipTests'
			}
		}

		
	} 
	
	post {
		always {
			echo 'Im awesome. I run always'
		}
		success {
			echo 'I run when you are successful'
		}
		failure {
			echo 'I run when you fail'
		}
	}
}
