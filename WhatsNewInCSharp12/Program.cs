using Person = (string name, uint age);

#pragma warning disable CA1852 // Seal internal types

DemonstrateAliasesForAnyType();

static void DemonstrateAliasesForAnyType()
{
	Console.WriteLine(nameof(DemonstrateAliasesForAnyType));
	Console.WriteLine();

	static Person GetPerson() => ("Jason", 30);

	var person = GetPerson();

	Console.WriteLine(person);
}

//DemonstrateDefaultParameterValuesForLambda();

static void DemonstrateDefaultParameterValuesForLambda()
{
	Console.WriteLine(nameof(DemonstrateDefaultParameterValuesForLambda));
	Console.WriteLine();

	var personGenerator = (string name = "Jason", uint age = 30) => new Person(name, age);

	var jasonPerson = personGenerator();
	Console.WriteLine(jasonPerson);

	var janePerson = personGenerator("Jane");
	Console.WriteLine(janePerson);

	var johnPerson = personGenerator("John", 22);
	Console.WriteLine(johnPerson);
}