//SCRIPTED

//DECLARATIVE
pipeline {
//	agent any
	
	agent { docker {image 'maven:3.6.3'}}

	environment {
		def dockerHome = tool 'myDocker'
        def mavenHome  = tool 'myMaven'
        env.PATH = "${dockerHome}/bin:${mavenHome}/bin:${env.PATH}"
	}

	stages {
		stage('Build') {
			steps {
			   echo 'mvn --version'
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
