## Things that i have added in the razor page and js for creating login page with validations.

Learn more about bootstrap (official documentation): https://getbootstrap.com/docs/4.5/getting-started/introduction/ 

Bootstrap classes references: https://bootstrapcreative.com/resources/bootstrap-4-css-classes-index/

### I have used some bootstrap classes in Index.cshtml:

Index.cshtml:

     <div class="row mx-auto justify-content-center">
        <form name="LoginForm">
        <h2>Log in</h2>       
        <div class="form-group">
            <input id="username" type="text" class="form-control" maxlength="12" placeholder="Username" required>
        </div>
        <div class="form-group">
            <input id="password" type="password" class="form-control"
            autocomplete="on" maxlength="18" placeholder="Password" required>
        </div>
        <div class="form-group">
            <button id="submit" type="submit" class="btn btn-primary btn-block">Log in</button>
        </div>       
        </form>
    </div>

site.js:

    const loginButton = document.getElementById('submit');
    loginButton.addEventListener('click', LoginFormValidation);

    function LoginFormValidation() {
        const userName = document.getElementById('username').value;
        const password = document.getElementById('password').value;
        /* passwordRegex - This regex only matches password with atleast 6 to 20    characters
        one numeric, one lowercase, one uppercase
        Regex ? - Regular expression which have special meanings for that expressions
        It is used to match a certain pattern */
        const passwordRegex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,20}$/;
        if (userName.length === 0)
        alert('Username cannot be empty !');
        if (!passwordRegex.test(password))
        alert('Password must have atleast one numeric,
        one Uppercase,one Lowercase character with atleast six characters long !');
        if (userName.length >= 1 && userName.length <= 12 && password.match(passwordRegex))
        alert('Login successful !');
    }

    



