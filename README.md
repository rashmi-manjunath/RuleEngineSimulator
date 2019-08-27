# RuleEngine
 
Assumption :
User has to upload json file which contins the stream of data.
All the data are case sensitive.

1)Approach and Trade-off :
  * Each stream of data(signal,Value_Type,value) is checked againist the added rule(Value_type,signal,condition,value) by comparing 
   signal and value type respectively.
  * Stream Value is compared with the added rule value and and returns the stream which violates the condition.
   
2)Runtime Perfomance
		*	Serialization and Deserialization.
		* O(n2) complexity.

3)Improvements
  * Application performance
  * Exception Handling
  * UI enhacements
