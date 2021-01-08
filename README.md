# Marks Aggregation
      StudentMarks(int numOfStudents , int numOfSubjects, int[,] studentMarks)
	  
#Description
        To aggregate marks find and remove the least subject in an array
		
#Paramteres
      numOfStudents - reprersent count of students
	  numOfSubjects - reprersent count of subjects
	  studentMarks - represents 2d array of subject marks with the correct specified length numOfStudents and numOfSubjects
	  
#Function
       FindAverageSubjectIndex method to find the min average subject index and return index integer value
	   TotalMarksExcludingSubject method add the all subject marks excluding the least subject index and return array with sum values of all subjects
	   
#Usage
     Create StudentMarks instance with passing 	numOfStudents , numOfSubjects and studentMarks array and call FindAverageSubjectIndex and TotalMarksExcludingSubject to get array with final sum of all subjects