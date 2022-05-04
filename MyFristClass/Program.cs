using MyFirstClass;

var evan = new TqlStudent("Evan", "Mercurio", 3);
var Levi = new TqlStudent("Levi", "Tracy", 9);
var Rebecca = new TqlStudent("Rebecca", "Owens", 4);
var Sarah = new TqlStudent("Sarah", "Wainscott", 1);
var Greg = new TqlStudent("Greg", "Doud", 6);
var evangit = new Assessment { Topic = "Git/Github", Points = 110, DateTaken = DateTime.Now };
var evansql = new Assessment { Topic = "SQL", Points = 110, DateTaken = DateTime.Now };

evan.GitGithubAssessment = evangit;
evan.GitGitSQL = evansql;

evan.HappyAnni();
evan.HappyAnni();
evan.HappyAnni();

Console.WriteLine(evan.Dad());
Console.WriteLine(Levi.Dad());
Console.WriteLine(Rebecca.Dad());
Console.WriteLine(Sarah.Dad());
Console.WriteLine(Greg.Dad());

var assessment1 = new Assessment { Topic = "SQL", Points = 110, DateTaken = DateTime.Now };
var git = new Assessment() { Topic = "Git/Github", Points = 110, DateTaken = DateTime.Now };
var Java = new Assessment() { Topic = "Java", Points = 110, DateTaken = DateTime.Now };
var angular = new Assessment() { Topic = "Angular", Points = 110, DateTaken = DateTime.Now };
var Csharp = new Assessment() { Topic = "C#", Points = 110, DateTaken = DateTime.Now };

var test = new TqlStudent()
    {
    FirstName = "LEVI",
    LastName = "Tracy",
    YearsOfService = 8,
    GitGithubAssessment = git,
    GitGitSQL = assessment1,
    GitGitAngular = angular,
    GitGitCSharp = Csharp,
    GitGitJavaScript = Java,
    };


Console.WriteLine(test.Dad());






