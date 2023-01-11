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
    [Route("AskingQuestions")]
    public string AskingQuestions()
    {
        return "It would create a web API application that will ask a series of questions";
    }

    [HttpGet]
    [Route("Greater or Less Than")]
    public string GreaterOrLessThan()
    {
        return "It would create a web API application that is capable of comparing two numbers and declaring whether they are less than, greater than, or equal to one another.";
    }

    [HttpGet]
    [Route("MadLib")]
    public string MadLib()
    {
        return "It would create a web API application that would be able of taking in users input to create a mad lib story.";
    }

    [HttpGet]
    [Route("OddOrEven")]
    public string OddOrEver()
    {
        return "It would create a web API application that is capable of declaring whether the user inputted number is odd or even.";
    }

    [HttpGet]
    [Route("ReverseIt")]
    public string ReverseIt()
    {
        return "It would create a web API application that is capable of taking users input and putting it in the reverse order.";
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
            StudentListModel result = new StudentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentsList.Count; i++)
            {
                // condition to check the studentlist firstname to our variable firstname

                if(studentsList[i].firstName == studentFirstName)
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
            StudentListModel result = new StudentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentsList.Count; i++)
            {
                // condition to check the studentlist firstname to our variable firstname

                if(studentsList[i].lastName == studentLastName)
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
            StudentListModel result = new StudentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentsList.Count; i++)
            {
                // condition to check the studentlist firstname to our variable firstname

                if(studentsList[i].slackName == studentSlackName)
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
            StudentListModel result = new StudentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentsList.Count; i++)
            {
                // condition to check the studentlist firstname to our variable firstname

                if(studentsList[i].email == studentEmail)
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
    [Route("RestaurantPicker")]
    public string RestaurantPicker()
    {
        return "It would create a web API application that will randomize a list of restaurants back to a user depending on which category of food they choose.";
    }
}
