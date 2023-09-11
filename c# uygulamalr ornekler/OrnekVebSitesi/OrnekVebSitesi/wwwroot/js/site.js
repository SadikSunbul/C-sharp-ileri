document.querySelector(".login-button").addEventListener("click", function (event) {
    event.preventDefault();


    var kontrol = document.querySelector(".Kontrol").value;

    // Giriş işlemini kontrol eden bir fonksiyon
    function checkLogin(kontrol) {
        if (kontrol) {
            return true; // Giriş başarılı
        } else {
            return false; // Giriş başarısız
        }
    }
    

    var isSuccessful = checkLogin(kontrol);
    var feedbackBox = document.getElementById("feedback-box");

    if (isSuccessful) {
        feedbackBox.innerHTML = "Giriş başarılı!";
        feedbackBox.className = "success";
    } else {
        feedbackBox.innerHTML = "Giriş başarısız!";
        feedbackBox.className = "error";
    }

    feedbackBox.style.display = "block";

    setTimeout(function () {
        feedbackBox.style.display = "none";
    }, 2000);
});
