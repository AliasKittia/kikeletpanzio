namespace kikeletpanzio2._0
{
    internal class Guest
    {
        #region adattípusok
        string identifier;
        string firstname;
        string lastname;
        string phonenumber;
       
        DateTime birthdate;
  
        string birthplace;
        string email;
        string password;
        bool vip;
        

        #endregion

        #region konstruktor
        public Guest(string identifier, string firstname, string lastname, string phonenumber, DateTime birthdate, string birthplace, string email, string password, bool vip)
        {
           Identifier = this.Identifier = CreateIdentifier(firstname, lastname); ;
           Firstname = firstname;
           Lastname = lastname;
           Phonenumber = phonenumber;
           Birthdate = birthdate;
    
           Birthplace = birthplace;
           Email = email;
           Password = password;
           Vip = vip;
            
        }

       
        #endregion


        #region getset
        public string Identifier { get => identifier; set => identifier = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        
        public string Birthplace { get => birthplace; set => birthplace = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool Vip { get => vip; set => vip = value; }
        
        #endregion

        #region tostring
        public override string ToString()
        {
            return $"Azonosító {identifier}\nVezetéknév {lastname}  Keresztnév {firstname}\nTelefonszám {phonenumber}\nSzületési idő {birthdate}\t " +
                $"Születési hely {birthplace}\nEmail {email}\n Jelszó {password}\n VIP{vip}";
        }
        #endregion

        #region azonosító készítés
        private string CreateIdentifier(string firstname, string lastname)
        {
            return $"{firstname}{DateTime.Now.ToString("yyyy")}";
        }
        #endregion
    }
}
