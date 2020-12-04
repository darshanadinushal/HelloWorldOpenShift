//SCRIPTED

//DECLARATIVE
pipeline {
	agent any
	
	environment {
		dockerHome = tool 'myDocker'
		PATH = "$dockerHome/bin:$PATH"
	}

	stages {
		stage('Checkout') {
			steps {
			    echo 'Checkout Start'
				sh 'docker version'
				echo "Build"
				echo "PATH - $PATH"
				echo "BUILD_NUMBER - $env.BUILD_NUMBER"
				echo "BUILD_ID - $env.BUILD_ID"
				echo "JOB_NAME - $env.JOB_NAME"
				echo "BUILD_TAG - $env.BUILD_TAG"
				echo "BUILD_URL - $env.BUILD_URL"
				echo 'Checkout End'
			}
		}
		stage('Compile') {
			steps {
				echo 'Compile or Build'
			}
		}

		stage('Test') {
			steps {
				echo 'Unit Test'
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

		stage('Build Docker Image') {
			steps {
				//"docker build -t darshanadinushal/helloworldapp:$env.BUILD_TAG"
				script {
					dockerImage = docker.build("darshanadinushal/helloworldapp:${env.BUILD_TAG}")
				}

			}
		}

		stage('Push Docker Image') {
			steps {
				script {
					docker.withRegistry('', 'dockerhub') {
						dockerImage.push();
						dockerImage.push('latest');
					}
				}
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
