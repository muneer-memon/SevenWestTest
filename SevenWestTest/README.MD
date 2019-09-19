# Seven West Test Project

## Task
This is a console application which outputs the following
•	The users full name for id=42
•	All the users first names (comma separated) who are 23
•	The number of genders per Age, displayed from youngest to oldest


## Supplied
Example file formatted with JSON on every row
e.g.
{ "id": 31, "first": "Jill", "last": "Scott", "age":66 }
Note: It might or might not be a valid JSON structure.


## Considerations
1.	The data source may change.
2.	The way source is fetched may change.
3.	The number of records may change (performance).
4.	The functionality may not always be consumed in a console app.

## output
The solution doesnt not require any user interaction and generates the following output.

Bill,Frank

Age:23 Female:0 Male:2

Age:54 Female:0 Male:1

Age:66 Female:3 Male:0

