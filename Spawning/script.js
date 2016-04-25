window.addEventListener("load", function () {
    var canvas = document.getElementById("canvas");
    var context = canvas.getContext("2d");

    var blokjes = [];
     var srcs = ["Images/dickbutt.png", "Images/mUWtowV.jpg" , "Images/Rare_0002cd_5507439.jpg", "Images/tumblr_ntd9g8zmGl1uwa0t9o1_500.jpg"];

    var image = new Image();
    image.src = "Images/dickbutt.png";
    image.height = 50;
    image.width = 50;

    image.addEventListener("load", function () {
        setInterval(animate, 10);
    })

     
    var liedje = new Audio();
    liedje.src = "Audio/Fresh Prince Of Dickbutt Bel Air.mp3";
    liedje.play();

    function animate() {

        context.clearRect(0, 0, 800, 800);
        if (Math.random() < 0.02) {
            var blokje = Object.create(Blokje);
            blokje.x = Math.random() * 800;
            blokje.y = -200;
            blokje.yStap = 0.5 + Math.random() * 3;
            blokjes.push(blokje);
        };

        for (i = 0; i < blokjes.length; i++) {
            blokjes[i].update();
            blokjes[i].teken(context,image);

            if (blokjes[i].y > 700) {
                blokjes.splice(i,1);
            }
        }
    }

})