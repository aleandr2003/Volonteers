using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Abstract
{
    public interface IPerson
    {
        int Id {get; set;}
    	string NickName {get; set;}
    	string FirstName {get; set;}
    	string LastName {get; set;}
	    string ICQNumber {get; set;}
    	string Email {get; set;}
    	string PhoneNumber1 {get; set;}
        string PhoneNumber2 {get; set;}
        string Hobbies {get; set;}
        string Skills {get; set;}

        List<IOpinion> OpinionsToMe { get; set; }

				//Avatar MyAvatar
    }
}
