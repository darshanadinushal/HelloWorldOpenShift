//SCRIPTED

//DECLARATIVE
pipeline {
	agent any
	
	environment {
		def dockerHome = tool 'myDocker'
        def mavenHome  = tool 'myMaven'
		PATH = "${dockerHome}/bin:${mavenHome}/bin:${PATH}"
	}


	stages {
		stage('Build') {
			steps {
			
			  //echo "PATH - $PATH"
			  sh 'sudo  docker version'
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
