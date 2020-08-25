## Things that i have added in the razor page and js for creating login page with validations

Index.cshtml:

     <div class="row mx-auto justify-content-center">
        <form name="LoginForm">
        <h2>Log in</h2>       
        <div class="form-group">
            <input id="username" type="text" class="form-control" maxlength="12" placeholder="Username" required>
        </div>
        <div class="form-group">
            <input id="password" type="password" class="form-control" autocomplete="on" maxlength="18" placeholder="Password" required>
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
    // passwordRegex - This regex only matches password with atleast 6 to 20 characters
    // one numeric, one lowercase, one uppercase
    // Regex ? - Regular expression which have special meanings for that expressions
    // It is used to match a certain pattern
    const passwordRegex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,20}$/;
    if (userName.length > 12 || userName.length === 0)
        alert('Username characters cannot be more than 12 or empty!');
    if (!passwordRegex.test(password))
        alert('Password must have atleast one numeric, one Uppercase, one Lowercase character with atleast six characters long!');
    if (userName.length >= 1 && userName.length <= 12 && password.match(passwordRegex))
        alert('Login successful !');
    }



