//Isaiah Keith Ferguson
//10/25/2022
//Restaurant Picker
//the user will input a type of food and depending on their answer will 
//generate a random restaurant to eat at.
//Peer Reviewed by: Marcel R- The program worked well. It took two imputs to narrow down what to get to eat. I like how it returns that wasn't an option if entered incorrectly. Really good work! :D

using Microsoft.AspNetCore.Mvc;

namespace FergusonIRestaurantPickerEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
//Resteruant Options
//asain - pho / sushi
//fast - burgers / pizza
// sit down - dinner / breakfast

    [HttpGet]
    [Route("RestaurantPicker/{input}/{inputfood}")]

    public string RestaurantPickerM(string input, string inputfood)
    {
        int num1 = 0;
        int num2 = 0;
        bool tro = true;
        string food = "";
        string[] Asian = { "Ramen King", "Legendary Ramen", "Pho King", "Phu Lucky", "Fox Creek Soup spot", "Hana Sushi", "Domo's", "Luu's Sushi Bowl", "Tora Sushi", "Fuji Sushi" };
        string[] fastFood = { "Mcdonalds", "Five Guys", "Jack N the Box", "Burger King", "Wendy's", "PizzaHut", "Dominoes", "fired Pizza", "Little Ceaser's", "Costco Pizza" };
        string[] SitDown = { "BJ's", "Outback", "Texas RoadHouse", "Chili's", "Olive Garden", "Black Bear Diner", "Mimosa Gourmet", "Chuck's", "HuckleBerries", "IHOP" };

        Random Randm = new Random();
        num2 = Randm.Next();


        tro = Int32.TryParse(input, out num1);

        if (input == "asian" || input == "fast" || input == "sit down")
        {
            if (tro == false)
            {
                if (input == "asian")
                {
                    if (inputfood != "pho" && inputfood != "sushi")
                    {
                        food = "Did you not listen?? i said Pho or Sushi!! next time listen";
                    }

                    if (inputfood == "pho")
                    {
                        num2 = Randm.Next(0, 4);

                        switch (1)
                        {
                            case 1:
                                food = $"lets go to {Asian[num2]}";
                                break;
                        }
                    }

                    if (inputfood == "sushi")
                    {
                        num2 = Randm.Next(5, 8);

                        switch (1)
                        {
                            case 1:
                                food = $"lets go to {Asian[num2]}";
                                break;
                        }
                    }
                }

                if (input == "fast")
                {
                    if (inputfood != "burgers" && inputfood != "pizza")
                    {
                        food = "My guy that wasn't an option.";
                    }

                    if (inputfood == "burgers")
                    {
                        num2 = Randm.Next(0, 4);

                        switch (1)
                        {
                            case 1:
                                food = $"Lets get some {fastFood[num2]}";
                                break;
                        }
                    }

                    if (inputfood == "pizza")
                    {
                        num2 = Randm.Next(5, 8);

                        switch (1)
                        {
                            case 1:
                                food = $"Lets get some {fastFood[num2]}";
                                break;
                        }
                    }
                }

                if (input == "sit down")
                {
                    if (inputfood != "dinner" && inputfood != "breakfast")
                    {
                        Console.WriteLine("you can't here or something mister?!? i said 'Dinner' or 'Breakfast' you nincompoop!");
                    }

                    if (inputfood == "dinner")
                    {
                        num2 = Randm.Next(0, 4);
                        switch (1)
                        {
                            case 1:
                                food = $"Lets go to {SitDown[num2]} since we have some extra time";
                                break;
                        }
                    }
                    if (inputfood == "breakfast")
                    {
                        num2 = Randm.Next(5, 8);

                        switch (1)
                        {
                            case 1:
                                food = $"Lets go to {SitDown[num2]} since we have some extra time";
                                break;
                        }
                    }
                }
            }
        }
        else
        {
            food = "That wasn't an option";
        }
        return food;
    }
}