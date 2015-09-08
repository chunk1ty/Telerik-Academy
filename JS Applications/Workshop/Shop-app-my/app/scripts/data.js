Parse.initialize("7yff86enotuGKA4mBxlnYEA7uF3IMpiNlvQPbmmI", "jsr5Ghn9CHgPqPWWJ24PSBDggCi61NfU3Jg24GJx");

export default  {
    users: {
        login: function(username, password){
            Parse.User.login(username, password);
        },
        logout: function(){
            return Parse.User.logOut();
        },
        register: function(username, password){
            var user = new Parse.User();
            user.set("username", username);
            user.set("password",password);

            return user.signUp();
        },
        current: function(){
            return Parse.User.current();
        }
    }
}