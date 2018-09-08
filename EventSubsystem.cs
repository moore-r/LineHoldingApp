using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hold_It_App
{

    
    
    //the spot class holds all the information for spots
    public class Spot
    {
        //the cost of a spot
        public int cost;

        //a randomly generated code for spots to confirm payment
        //probably wont end up using this
        private int spotcode;

        //short description of a spot
        public string spot_description;

        //the unique ID for both holddes and customers
        public string holdeeID;
        public string customerID;

        //Boolean to show if the spot is already taken
        public Boolean taken = false;

        //a pointer to the next spot
        public Spot nextspot;

        //getter for the cost
        public int get_cost()
        {
            return cost;
        }

        //getter for spot description
        public string get_spotdesc()
        {
            return spot_description;
        }

        //ggeters for both od the IDS
        public string get_holdeeid()
        {
            return holdeeID;
        }
        public string get_customerid()
        {
            return customerID;
        }

        //getter for the taken boolean
        public Boolean get_taken()
        {
            return taken;
        }

        //set the taken boolean to true
        public void set_taken(string CustID)
        {
            this.customerID = CustID;
            this.taken = true;
        }

        //generate the code for the spot
        private int generatecode()
        {
            //generate the number
            Random random = new Random();
            int code = random.Next(0, 99999);

            return spotcode;
        }

        public void reset_spot()
        {
            this.customerID = null;
        }
    }







    //the event class, hols all the information for event as well as the linked list for spots
    public class Event
    {
        //This first section handles all the stuff for events
        //relevant times
        //these most likely wont be needed. but putting in just in case
        /*
        public int endtime;
        public int begintime;
        public int currenttime;
        */

        //basic event decription stuff
        //public string Eventname;
        //public string description;
        public string address;

        //pointer to the next event
        public Event next;



        //this second section of the class handles stuff for the linked list of spots
        //the number of spots in the list
        public int number_of_spots;

        //the number of 'unhidden spots' or spots that are yet to be taken
        public int non_hidden_spots;

        //head of the spotlist
        public Spot spothead;

        /*
        //a getter for the begin time
        public int get_begintime()
        {
            return begintime;
        }

        //a getter for the end time
        public int get_endtime()
        {
            return endtime;
        }

        //getter for event name, address and description
        public string get_eventname()
        {
            return Eventname;
        }
        public string get_description()
        {
            return description;
        } */
        
        public string get_address()
        {
            return address;
        }

        //A constructor
        public Event()
        {
            number_of_spots = 0;
            non_hidden_spots = 0;
            spothead = null;
        }


        //getter for number of spots in the list (total spots)
        public int get_number_of_spots()
        {
            return number_of_spots;
        }

        //getter for number of non-hidden spots in the list
        public int get_non_hidden_spots()
        {
            return non_hidden_spots;
        }

        //Now, adding a spot to the list
        public int addspot(Spot newspot)
        {
            //creating the new spot
            Spot samplespot = new Spot();

            //adding it to the list
            samplespot = newspot;
            samplespot.nextspot = spothead;
            spothead = newspot;

            //increment the counter
            non_hidden_spots += 1;
            return number_of_spots++;
        }

        //function that finds a specific spot by transversing a certain 
        //number of times and marks it as taken
        public bool select_spot(int where_to, string the_cust_id)
        {
            //set current equal to the head
            Spot currentS = spothead;
            int i = 0;

            //while loop for transversal
            while(currentS != null)
            {
                //check if it is the correct spot
                if(i == where_to)
                {
                    //set the flag to show spot is taken
                    currentS.set_taken(the_cust_id);
                    //remove the spot from list of non hidden spots (make it hidden)
                    this.non_hidden_spots -= 1;
                    return true;
                }
                else
                {
                    //if the spot isnt flagged, then its still available so add to the
                    //non hidden counter
                    if(currentS.taken == false)
                    {
                        i += 1;
                    }
                    //transverse
                    currentS = currentS.nextspot;
                }
            }

            return false;
        }

        //function to transverse list and return a spot but only counting non hidden spots(not taken or flagged)
        public Spot transverse(int number_trans)
        {
            //set a current equal to the head
            Spot Currents = spothead;
            int i = 0;

            //loop
            while(Currents != null)
            {
                //check if we have transversed enough times
                if(i == number_trans)
                {
                    //if we have return the spot
                    return Currents;
                }

                //if we havent add 1 to i and set current equal to the next pointer
                //but only if the spot is not hidden
                if(Currents.taken == false)
                {
                    i += 1;                   
                }
                Currents = Currents.nextspot;
            }

            return null;
        }

        //check if a user had already created a spot
        public Boolean check_dup(string dup_id)
        {
            Spot currrentd = spothead;

            while (currrentd != null)
            {
                //check if it is dup and if so return true
                if (currrentd.holdeeID == dup_id)
                {
                    return true;
                }

                //else transverse
                currrentd = currrentd.nextspot;
            }


            return false;
        }

        //pretty much the same as above but returns a spot based on holdee id
        public Spot spothid_getter(string the_ID)
        {
            Spot currentg = spothead;

            //transverese and check every spot
            while(currentg != null)
            {
                if (currentg.holdeeID == the_ID)
                    return currentg;
                currentg = currentg.nextspot;
            }

            return null;
        }

        //pretty much the same as above but returns a spot based on holdee id
        public Spot spotcid_getter(string the_CID)
        {
            Spot currentQ = spothead;

            //transverese and check every spot
            while (currentQ != null)
            {
                if (currentQ.customerID == the_CID)
                    return currentQ;
                currentQ = currentQ.nextspot;
            }

            return null;
        }

        //check if a customer has already bought a spot
        public Boolean check_dupcust(string dup_Cid)
        {
            Spot currrentd = spothead;

            while (currrentd != null)
            {
                //check if it is dup and if so return true
                if (currrentd.customerID == dup_Cid)
                {
                    return true;
                }

                //else transverse
                currrentd = currrentd.nextspot;
            }


            return false;
        }

        public Boolean delete(string ID)
        {
            Spot currentD = spothead;
            Spot previous;

            //check if the head is the one to delete

            if(currentD.holdeeID == ID)
            {
                //set the head to equal the second node
                spothead = spothead.nextspot;

                //decrease the spot counter
                this.number_of_spots -= 1;
                this.non_hidden_spots -= 1;

                //check if the spot lsit is now empty
                if (spothead == null)
                {
                    //if it is then the list is now empty return for event deletion

                    return true;
                }
                return false;
            }

            //if not, traneverse a litte
            previous = currentD;
            currentD = currentD.nextspot;


            //and loop
            while(currentD != null)
            {
                if(currentD.holdeeID == ID)
                {
                    //delete the spot
                    previous.nextspot = currentD.nextspot;
                    currentD.nextspot = null;

                    //decrease the spot counter
                    this.number_of_spots -= 1;
                    this.non_hidden_spots -= 1;

                    return false;
                }

                //if not transverse
                currentD = currentD.nextspot;
            }

            return false;

        }

    }





    //this class will hold the list of events
    public class Event_Database
    {
        //counter
        public int eventcount = 0;

        //constructor?
        public Event_Database()
        {
            eventcount = 0;
            eventhead = null;

        }

        //head of the list
        public Event eventhead;

        //simple counter to return the number of events in the list
        public int eventcounter()
        {
            return eventcount;
        }

        //add an Event to the list
        public int add(Event newevent)
        {
            //create the new event
            Event addevent = new Event();

            //add it to the list
            addevent = newevent;
            addevent.next = eventhead;
            eventhead = addevent;

            //increment the counter
            return eventcount++;
        }

        //Now we need a function that finds a specific event and adds a spot
        public Boolean spot_to_event(string Eloc, Spot thespot)
        {
            //a way to look through the list
            Event current = eventhead;


            //now transverse the list until we find a matching name
            while(current != null)
            {
                //check if we have a match
                if (Eloc == current.address)
                {
                    //if we do call the add spot function
                    current.addspot(thespot);

                    //return true as the spot has been added
                    return true;
                }

                //if it is not the correct event 
                current = current.next;
            }

            //return false as the spot has not been added
            return false; 
        }

        //now a function that finds a specific event by address
        public Event findaddress(string searchaddress)
        {
            //way to look through the list
            Event currentA = eventhead;

            //transverse the lsit until we have a match 
            while(currentA != null)
            {
                //check for a match
                if(searchaddress == currentA.address)
                {
                    //we return the current event
                    return currentA;
                }

                //if its not a match we go to the next event in the list
                currentA = currentA.next;
            }

            return null;
        }


        //function to check each event for a spot
        public Boolean check_event(string HID)
        {
            //storer
            Event currentE = eventhead;

            //loop and call function
            while(currentE != null)
            {
                if (currentE.check_dup(HID))
                    return true;
                //if not transverse
                currentE = currentE.next;

            }

            return false;
        }
        
        //check every event for match holdee Id
        public Spot HID_event(string IDH)
        {
            Event currentW = eventhead;
            Spot currentZ;

            while(currentW != null)
            {
                //set and stor info
                currentZ = currentW.spothid_getter(IDH);
                if (currentZ != null)
                    return currentZ;
                currentW = currentW.next;
            }

            return null;
        }

        //check every event for match holdee Id
        public Spot CID_event(string IDC)
        {
            Event currentP = eventhead;
            Spot currentK;

            while (currentP != null)
            {
                //set and stor info
                currentK = currentP.spotcid_getter(IDC);
                if (currentK != null)
                    return currentK;
                currentP = currentP.next;
            }

            return null;
        }

        //function to check each event for a spot
        public Boolean check_cust_event(string HID)
        {
            //storer
            Event currentE = eventhead;

            //loop and call function
            while (currentE != null)
            {
                if (currentE.check_dupcust(HID))
                    return true;
                //if not transverse
                currentE = currentE.next;

            }

            return false;
        }

        //fucntion to delete a spot based on holdee id
        public void deletionspot(string I_D)
        {
            Event currentde = eventhead;
            Event previousde;

            //check if teh first event has it
            //and if not loop
            if (currentde.delete(I_D))
            {
                //then we remove it from the list and return
                eventhead = eventhead.next;
                eventcount -= 1;

                return;
            }

            //set the holders up
            previousde = currentde;
            currentde = currentde.next;

            //loop and call
            while(currentde != null)
            {
                if (currentde.delete(I_D))
                {
                    //then we have to also delete the event
                    previousde = currentde.next;
                    currentde.next = null;
                    eventcount -= 1;

                    return;

                }
                currentde = currentde.next;
            }

            return;
        }
    }





    




    //class to control events and pass stuff to the interface
    public class Event_Controller
    {
        //Creates a single event database
        public Event_Database Edatabase = new Event_Database();
        //a template made to help create new events and add them to the list
        public Event eventcreator;
        //a template to help add new spots to the lsit
        public Spot spotcreator;



        //function to add an event to the database
        //CHECKS IF ADDRES IS ALREADY IN USE AND ACTS ACCORDINGLY
        public void addtoDB(string loc, string desc, string accountid, int spotCost)
        {
            //firstly check if the adress is unique
            bool exsist;
            exsist = checkaddress(loc);

            //if it is already there(true) the just add a spot to it
            if (exsist)
            {
                spot_to_event(spotCost, desc, accountid, loc);
            }
            else //if it doesnt exsist create the event and then add a spot to it
            {
                //create the new event
                eventcreator = new Event();

                //take the data passed into the function and put it in the new event.
                eventcreator.address = loc;

                //now to call the function in event database that will add it to the list
                Edatabase.add(eventcreator);

                // now that the event exsists call the add spot function
                spot_to_event(spotCost, desc, accountid, loc);
            }           
        }



        //function to add a spot to an event
        public void spot_to_event(int spotcost, string spotdesc, string hID, string the_Eloc)
        {
            //create the new spot
            spotcreator = new Spot();

            //use the data passed in above and pass it into the spot
            spotcreator.cost = spotcost;
            spotcreator.spot_description = spotdesc;
            spotcreator.holdeeID = hID;

            //now we have to call the function to add the spot to the list
            Edatabase.spot_to_event(the_Eloc, spotcreator);
        }



        //function to search the event database for an event with
        //a matching address
        public Event findbyaddress(string locfind)
        {
            //new event to pass back
            Event eventsearch = new Event();

            //copy the contents of the event fount by the findadress fuction into the event
            eventsearch = Edatabase.findaddress(locfind);

            //return the event.
            return eventsearch;            
        }



        //similar to the above function, but it returns a boolean
        //saying if the adress is already being used
        public Boolean checkaddress(string loccheck)
        {
            //new event to hold info
            Event event_loc_check = new Event();

            //searhc for adress and copy contents into the event
            event_loc_check = Edatabase.findaddress(loccheck);

            if (event_loc_check == null)
                return false;
            else
                return true;
        }



        //A function to select a spot in the event by event name and holdee ID
        public void select_spot(string event_loc, int go_spot, string customer_name)
        {
            //find the event
            Event finder = new Event();
            finder = Edatabase.findaddress(event_loc);

            //now select the spot
            finder.select_spot(go_spot, customer_name);

        }



        //just a function so joe can easily get the number of unhidden spots
        public int get_free_spots(Event spot_numbers)
        {
            return spot_numbers.non_hidden_spots;
        }



        //a function to transverse the list a certain number of times 
        public Spot transverse_list(Event list_event, int number_to_trans)
        {
            //new spoit to hold the info
            Spot spot_found = new Spot();

            //find the spot and store it
            spot_found = list_event.transverse(number_to_trans);

            //return the spot
            return spot_found;
        }

        //a function to check if a user has already posted a spot
        public Boolean check_spot(string dup_add)
        {
            //call teh functio check
            if (Edatabase.check_event(dup_add))
                return true;
            return false;
        }


        //function that returns a spot based on the ID
        public Spot get_holdee_spot(string theid)
        {
            //set the spot
            Spot H_ID;
            H_ID = Edatabase.HID_event(theid);

            //return the spot
            return H_ID;
        }

        //same as a bove but iwth cust ID
        public Spot get_cust_spot(string custid)
        {
            //set the spot
            Spot C_ID;
            C_ID = Edatabase.CID_event(custid);

            //return the spot
            return C_ID;

        }

        //check if a customer has already bought an event
        public Boolean check_cust_spot(string cust_dupid)
        {
            if (Edatabase.check_cust_event(cust_dupid))
                return true;
            return false;
        }

        //delete a spot if the holdee id is a match
        public void delete_spot(string hold_id)
        {
            //just call the function
            Edatabase.deletionspot(hold_id);
            return;
        }
    }
}
