const signupForm = document.querySelector("#signup-form");

signupForm.addEventListener('submit', e => {
    e.preventDefault();
    const email = signupForm['email'].value;
    const password = signupForm['password'].value;
    const confirmPassword = signupForm['confirmPassword'].value;

    if (confirmPassword === password) {
        auth.createUserWithEmailAndPassword(email, password).then(cred => {
            return db.collection('users').doc(cred.user.uid).set({
                email, password
            }).then(() => {
                console.log('success');
                signupForm.reset();
                location = "login.html";
            }).catch(err => {
                console.log(err.message);
            })
        }).catch(err => {
            console.log(err.message);
        })
    }
    else {
        alert('Введенные пароли не совпадают!')
    }


})