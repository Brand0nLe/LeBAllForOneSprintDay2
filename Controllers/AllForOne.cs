using Microsoft.AspNetCore.Mvc;
using StudentDirectoryApi.Models;

namespace LeBAllForOneSprintDay2.Controllers;

[ApiController]
[Route("[controller]")]
public class AllForOneController : ControllerBase
{
    [HttpGet]
    [Route("SayHello/{name}")]
    public string SayHello(string name)
    {
        return $"Hello {name}! I hope you're having a great day today! You're doing great! You got this! :)";
    }

    [HttpGet]
    [Route("Add2Numbers/{number1}/{number2}")]
    public int Add2Numbers(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);

        return convertNum1 + convertNum2;
    }

    [HttpGet]
    [Route("AskingQuestions/{name}/{time}")]
    public string askingQuestions(string name, string time)
    {
        return $"Hi there what's your name? \n Wow what a beautiful name you have {name}! It's nice to finally meet you! \n What time did you wake up today? \n Wow you woke up at {time} AM?! You must be fully rested :)";
    }

    [HttpGet]
    [Route("GreaterOrLessThan/{number1}/{number2}")]
    public string greaterOrLessThan(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);

        if (convertNum1 > convertNum2)
        {
            return $"{convertNum1} is greater than {convertNum2} \n {convertNum2} is less than {convertNum1}";
        }
        else if (convertNum1 < convertNum2)
        {
            return $"{convertNum2} is greater than {convertNum1} \n {convertNum1} is less than {convertNum2}";
        }
        else
            return $"{convertNum1} is equal to {convertNum2}";
    }

    [HttpGet]
    [Route("MadLib/{nameOne}/{nameTwo}/{yummyFlavor}/{nastyFlavor}/{number1}/{animal}/{color}/{number2}/{emotion}/{number3}")]
    public string MadLib(string nameOne, string nameTwo, string yummyFlavor, string nastyFlavor, int number1, string animal, string color, int number2, string emotion, int number3)
    {
        return $"One day there were two friends named {nameOne} and {nameTwo}. {nameOne} decided they wanted to bake a {yummyFlavor} cake and asked {nameTwo} to come over and help. While they were mixing the ingredients {nameTwo} accidentally grabbed the wrong flavor and added in {nastyFlavor}! Neither of them realized and just continued baking. After {number1} hours they finally finished baking the cake and were ready to decorate. They shaped the cake into a {animal} and put {color} icing on it. After {number2} hours of decorating they finally finished and could taste it! They both took a bite and immediately spit out! Why did the cake taste like {nastyFlavor}?! They were feeling {emotion} after their huge failure and decided to door dash {number3} orders of french fries to make themselves feel better.\n\n\n\n How was it? Wasn't it a ton of fun?!";
    }

    [HttpGet]
    [Route("OddOrEven/{number}")]
    public string OddOrEven(string number, bool canParse, int validNum, int remainder)
    {
        canParse = Int32.TryParse(number, out validNum);

        if (canParse == false)
        {
            return "ERROR invalid entry. You can only input numbers!";
        }
        else
        {
            if (remainder == (validNum % 2))
            {
                return $"Your number {number} is even.";
            }
            else
            {
                return $"You number {number} is odd";
            }
        }
    }

    [HttpGet]
    [Route("ReverseIt/{userInput}")]
    public string ReverseIt(string userInput)
    {
        string reversedOutput ="";

    for (int i = userInput.Length - 1; i >= 0; i--)
    {
        reversedOutput = reversedOutput + userInput[i];
    }
        return reversedOutput;
    }





    // student list starts here
    //making a list of students with the student list model
    public List<StudentListModel> studentsList = new List<StudentListModel>()
        {
            // call the constructor to add the students
            new StudentListModel(){
                firstName = "Harrison",
                lastName = "Busby",
                slackName = "Harrison Busby",
                email = "hbusby@codestack.co",
                hobbies = "Piano"
            },
            new StudentListModel(){
                firstName = "Brandon",
                lastName = "Le",
                slackName = "Brandon Le",
                email = "ble@codestack.co",
                hobbies = "Eating & Sleeping"
            },
            new StudentListModel(){
                firstName = "Jessie",
                lastName = "Lamzon",
                slackName = "Jessie Lamzon",
                email = "jlamzon@codestack.co",
                hobbies = "Eating & Traveling"
            },
                new StudentListModel(){
                firstName = "Andrea",
                lastName = "Burr",
                slackName = "Andrea Burr",
                email = "aburr@codestack.co",
                hobbies = "Horse Riding"
            },
                new StudentListModel(){
                firstName = "Daniel",
                lastName = "Decoito",
                slackName = "Daniel Decoito",
                email = "dDecoiro@codestack.co",
                hobbies = "Bears, beets, battlestar galactica"
            },
                new StudentListModel(){
                firstName = "Pedro",
                lastName = "Castaneda",
                slackName = "Pedro Castaneda",
                email = "pcastaneda@codestack.co",
                hobbies = "Hiking & traveling"
            },
                new StudentListModel(){
                firstName = "Jeremy",
                lastName = "Lapham",
                slackName = "Muscle Baby",
                email = "jlapham@codestack.co",
                hobbies = "Body building, power lifting, wrestling"
            },
                new StudentListModel(){
                firstName = "Jacob",
                lastName = "Dekok",
                slackName = "Jacob Dekok",
                email = "jdekok@codestack.co",
                hobbies = "Copying Jeremy. Body building, powerlifting, wrestling"
            },
                new StudentListModel(){
                firstName = "Kenneth",
                lastName = "Fujimura",
                slackName = "Kenneth Fujimura",
                email = "kfujimura@codestack.co",
                hobbies = "Games, sports, model kits, anime, naps, culinary tourism"
            },
                new StudentListModel(){
                firstName = "Fernando",
                lastName = "Aguilar",
                slackName = "Freddy Aguilar",
                email = "faguilar@codestack.co",
                hobbies = "Playing video games, reading, writing"
            },
                new StudentListModel(){
                firstName = "Jovann",
                lastName = "Contreras",
                slackName = "Jovan Contreras",
                email = "jcontreras@codestack.co",
                hobbies = "Collecting comics"
            },
                new StudentListModel(){
                firstName = "Andrew",
                lastName = "Nilsson",
                slackName = "Drew Nilsson",
                email = "anilsson@codestack.co",
                hobbies = "Playing video games"
            },
                new StudentListModel(){
                firstName = "Lerissa",
                lastName = "Lazar",
                slackName = "Lerissa Lazar",
                email = "llazar@codestack.co",
                hobbies = "Drawing & watching anime"
            },
                new StudentListModel(){
                firstName = "N. Harrison",
                lastName = "Wilkins",
                slackName = "Harrison Wilkins",
                email = "nwilkins@codestack.co",
                hobbies = "skating & coding"
            },
                new StudentListModel(){
                firstName = "Madeline",
                lastName = "Gowan",
                slackName = "Maddie Gowan",
                email = "mgowan@codestack.co",
                hobbies = "Rodents"
            },
                new StudentListModel(){
                firstName = "Manuel",
                lastName = "Leyva",
                slackName = "Manuel Leyva",
                email = "mleyva@codestack.co",
                hobbies = "photography"
            },
                new StudentListModel(){
                firstName = "Elizar",
                lastName = "Garcia",
                slackName = "Elizar Garcia",
                email = "egarcia@codestack.co",
                hobbies = "Bowling and sleeping"
            },
                new StudentListModel(){
                firstName = "Mark",
                lastName = "Ramirez",
                slackName = "Mark Ramirez",
                email = "mramirez@codestack.co",
                hobbies = "Games and drinking way too much water"
            },
                new StudentListModel(){
                firstName = "Chris",
                lastName = "Martinez",
                slackName = "Chris Martinez",
                email = "cmartinez@codestack.co",
                hobbies = "Playing ping pong"
            },
                new StudentListModel(){
                firstName = "Samuel",
                lastName = "Laguna",
                slackName = "Samuel Laguna",
                email = "slaguna@codestack.co",
                hobbies = "unknown"
            },
                new StudentListModel(){
                firstName = "Isaiah",
                lastName = "Ferguson",
                slackName = "Isaiah Ferguson",
                email = "iferguson@codestack.co",
                hobbies = "Martial arts, tricking, hiking, and watching slice of life anime"
            },
                new StudentListModel(){
                firstName = "John",
                lastName = "Magpantay",
                slackName = "John Magpantay",
                email = "jmagpantay@codestack.co",
                hobbies = "FPS games"
            },
                new StudentListModel(){
                firstName = "Reed",
                lastName = "Goodwin",
                slackName = "Reed Goodwin",
                email = "rgoodwin@codestack.co",
                hobbies = "Hiking, video games, and skateboarding"
            },
                new StudentListModel(){
                firstName = "Amar",
                lastName = "Mann",
                slackName = "Amar Mann",
                email = "amann@codestack.co",
                hobbies = "Kicking rocks"
            },
                new StudentListModel(){
                firstName = "Marcel",
                lastName = "Rodriguez",
                slackName = "Marcel Rodriguez",
                email = "mrodriguez@codestack.co",
                hobbies = "Anime and pokemon"
            },
                new StudentListModel(){
                firstName = "Richard",
                lastName = "Johnson",
                slackName = "Richard Johnson",
                email = "rjohnson@codestack.co",
                hobbies = "Watching youtube, sketching, playing video games"
            },
                new StudentListModel(){
                firstName = "Ulises",
                lastName = "Ortega",
                slackName = "Ulises Ortega",
                email = "uortega@codestack.co",
                hobbies = "Video games, roller blading, board games"
            },
                new StudentListModel(){
                firstName = "Caroline",
                lastName = "Hana",
                slackName = "Caroline Hana",
                email = "chana@codestack.co",
                hobbies = "Video games, anime, and hanging out with friends"
            },
                new StudentListModel(){
                firstName = "Aisha",
                lastName = "Mashrah",
                slackName = "Aisha Mashrah",
                email = "amashrah@codestack.co",
                hobbies = "painting"
            },
                new StudentListModel(){
                firstName = "Shaun",
                lastName = "Aguirre-Reyes",
                slackName = "saguirre-reyes",
                email = "saguirre-reyes@codestack.co",
                hobbies = "writing and listening to music"
            },
                new StudentListModel(){
                firstName = "Griffin",
                lastName = "Parker",
                slackName = "Griffin Parker",
                email = "gparker@codestack.co",
                hobbies = "Singing, Reading, Playing video games"
            },
                new StudentListModel(){
                firstName = "Kent",
                lastName = "Tupas",
                slackName = "Kent Tupas",
                email = "ktupas@codestack.co",
                hobbies = "anime, osu player, drawing"
            }
        };
    // End of student list




    [HttpGet]
    [Route("StudentDirectoryFN/{studentFirstName}")]
    public StudentListModel StudentDirectoryFN(string studentFirstName)
    {
        StudentListModel result = new StudentListModel()
        {
            firstName = "N/A",
            lastName = "N/A",
            slackName = "N/A",
            email = "N/A",
            hobbies = "N/A"
        };

        for (int i = 0; i < studentsList.Count; i++)
        {
            // condition to check the studentlist firstname to our variable firstname

            if (studentsList[i].firstName == studentFirstName)
            {
                result = studentsList[i];
                break;
            }
            // else{
            //     result.firstName = "N/A";
            //     result.lastName = "N/A";
            //     result.slackName = "N/A";
            //     result.email = "N/A";
            //     result.hobbies = "N/A";
            // }
        }

        return result;
    }


    [HttpGet]
    [Route("StudentDirectoryLN/{studentLastName}")]
    public StudentListModel StudentDirectoryLN(string studentLastName)
    {
        StudentListModel result = new StudentListModel()
        {
            firstName = "N/A",
            lastName = "N/A",
            slackName = "N/A",
            email = "N/A",
            hobbies = "N/A"
        };

        for (int i = 0; i < studentsList.Count; i++)
        {
            // condition to check the studentlist firstname to our variable firstname

            if (studentsList[i].lastName == studentLastName)
            {
                result = studentsList[i];
                break;
            }
            // else{
            //     result.firstName = "N/A";
            //     result.lastName = "N/A";
            //     result.slackName = "N/A";
            //     result.email = "N/A";
            //     result.hobbies = "N/A";
            // }
        }

        return result;
    }


    [HttpGet]
    [Route("StudentDirectorySN/{studentSlackName}")]
    public StudentListModel StudentDirectorySN(string studentSlackName)
    {
        StudentListModel result = new StudentListModel()
        {
            firstName = "N/A",
            lastName = "N/A",
            slackName = "N/A",
            email = "N/A",
            hobbies = "N/A"
        };

        for (int i = 0; i < studentsList.Count; i++)
        {
            // condition to check the studentlist firstname to our variable firstname

            if (studentsList[i].slackName == studentSlackName)
            {
                result = studentsList[i];
                break;
            }
            // else{
            //     result.firstName = "N/A";
            //     result.lastName = "N/A";
            //     result.slackName = "N/A";
            //     result.email = "N/A";
            //     result.hobbies = "N/A";
            // }
        }

        return result;
    }


    [HttpGet]
    [Route("StudentDirectoryEmail/{studentEmail}")]
    public StudentListModel StudentDirectoryEmail(string studentEmail)
    {
        StudentListModel result = new StudentListModel()
        {
            firstName = "N/A",
            lastName = "N/A",
            slackName = "N/A",
            email = "N/A",
            hobbies = "N/A"
        };

        for (int i = 0; i < studentsList.Count; i++)
        {
            // condition to check the studentlist firstname to our variable firstname

            if (studentsList[i].email == studentEmail)
            {
                result = studentsList[i];
                break;
            }
            // else{
            //     result.firstName = "N/A";
            //     result.lastName = "N/A";
            //     result.slackName = "N/A";
            //     result.email = "N/A";
            //     result.hobbies = "N/A";
            // }
        }

        return result;
    }










    [HttpGet]
    [Route("RestaurantPicker/{choice}")]
    public string RestaurantPicker(string choice)
    {

    string [] asianFood = {"Mama's Pho", "Green Papaya", "Komachi Sushi", "OZ Korean BBQ", "Bonchon", "Royal Siam", "M Sushi", "Tasty Pot", "Blue House Korean BBQ", "RAW Sushi Bistro"};
    string [] fastFood = {"McDonald's", "Taco Bell", "Wendy's", "Jack In The Box", "Popeye's", "Burger King", "Wingstop", "Sonic's", "Del Taco", "Raising Cane's"};
    string [] beverages = {"T4", "Happy Lemon", "Jamba Juice", "Bober Tea", "Kung Fu Tea", "7 Leaves Cafe", "Purple Kow", "Boba Guys", "Sharetea", "Tea Dazed"};
    
        if(choice == "ASIAN")
        {
        Random r = new Random();
        int randomInt = r.Next(0, 9);
        return $"You chose Asian Food! You should try: {asianFood[randomInt]}";
        }
        
        if(choice == "FAST")
        {
        Random r = new Random();
        int randomInt = r.Next(0, 9);
        return $"You chose Fast Food! You should try: {fastFood[randomInt]}";
        }
                
        if(choice == "DRINKS")
        {
        Random r = new Random();
        int randomInt = r.Next(0, 9);
        return $"Someone's thirsty! You should try: {beverages[randomInt]}";
        }
        
        else
        {
            return "You entered an invalid choice! Please enter ASIAN, FAST, or DRINKS.\n **DON'T FORGET TO PUT THEM IN ALL CAPS**";
        }
    }
}
