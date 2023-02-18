using System;

class Program
{
    static void Main(string[] args)
    {
        //Write a program that creates at least one event of each type and sets all of their values. 
        //For each event, call each of the methods to generate the marketing messages and output their results to the screen.

        LectureEvent lecture = new LectureEvent("J.K. Rowling", 50);
        lecture.setEventTitle("How to stand up for what is right.");
        lecture.setDescription("J.K. Rowling at her best. Our beloved novelist will share how she stands for what is right.");
        lecture.setDate("03/16/2023");
        lecture.setTime("2pm");
        lecture.setAddress("134 Azkaban St.", "Queen Creek", "Arizona", "USA");

        Console.WriteLine("\n\n");
        lecture.displayStandardMessage();
        lecture.displayFullDetails();
        lecture.displayShortDescription();
                        

        ReceptionEvent reception = new ReceptionEvent("Leizel@gmail.com");
        reception.setEventTitle("Red-Hat Ladies Tea");
        reception.setDescription("A luncheon for the Red-Hat Ladies of a Certain Age");
        reception.setDate("05/19/2023");
        reception.setTime("3pm"); 
        reception.setAddress("342 Dowling St.", "Scottsdale", "Arizona", "USA");

        Console.WriteLine("\n\n");
        reception.displayStandardMessage();
        reception.displayFullDetails();
        reception.displayShortDescription();

        OutdoorEvent outdoorPicnic = new OutdoorEvent("Sunny");
        outdoorPicnic.setEventTitle("Make Friends in the Park");
        outdoorPicnic.setDescription("A large community picnic for all ages. Please bring your own food and entertainment.");
        outdoorPicnic.setDate("06/15/2023");
        outdoorPicnic.setTime("10am-2pm"); 
        outdoorPicnic.setAddress("675 Main St.", "Show Low", "Arizona", "USA");

        Console.WriteLine("\n\n");
        outdoorPicnic.displayStandardMessage();
        outdoorPicnic.displayFullDetails();
        outdoorPicnic.displayShortDescription();

    }
}