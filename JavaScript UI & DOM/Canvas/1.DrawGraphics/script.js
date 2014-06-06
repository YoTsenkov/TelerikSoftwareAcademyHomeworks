window.onload = function () {
    var canvas = document.getElementById('canvas');
    var ctx = canvas.getContext('2d');

    //BICYCLE
    //back wheel
    ctx.beginPath();
    ctx.save();
    ctx.arc(180, 420, 50, 0, 2 * Math.PI);
    ctx.fillStyle = '#90CAD7';
    ctx.fill();
    ctx.strokeStyle = '#2D788B';
    ctx.stroke();
    //frame
    ctx.beginPath();
    ctx.moveTo(180, 420);
    ctx.lineTo(240, 350);
    ctx.lineTo(225, 320);
    ctx.lineTo(200, 320);
    ctx.moveTo(225, 320);
    ctx.lineTo(250, 320);
    ctx.moveTo(240, 350);
    ctx.lineTo(380, 350);
    ctx.lineTo(375, 310);
    ctx.lineTo(325, 325);
    ctx.moveTo(375, 310);
    ctx.lineTo(405, 270);
    ctx.moveTo(380, 350);    
    ctx.stroke();
    //front wheel
    ctx.beginPath();
    ctx.arc(390, 420, 50, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    ctx.moveTo(390, 420);
    ctx.lineTo(380, 350);
    ctx.lineTo(270, 425);
    ctx.stroke();
    //pedal
    ctx.beginPath();
    ctx.arc(270, 425, 15, 0, Math.PI / 4);
    ctx.lineTo(290, 445);
    ctx.arc(270, 425, 15, Math.PI / 4, Math.PI + Math.PI / 4);
    ctx.lineTo(251, 405);
    ctx.arc(270, 425, 15, Math.PI + Math.PI / 4, 2*Math.PI);
    ctx.moveTo(270, 425);
    ctx.lineTo(240, 350);
    ctx.moveTo(270, 425);
    ctx.lineTo(180, 420);
    ctx.stroke();
    
    //MISTER HAT
    //head
    ctx.beginPath();
    ctx.arc(240, 220, 50, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    //ctx.save();
    //eyes
    ctx.beginPath()
    ctx.scale(1.7, 1);
    ctx.arc(125, 200, 6, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(145, 200, 6, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();
    ctx.beginPath();
    ctx.scale(1, 3);
    ctx.arc(143, 66.5, 2, 0, 2 * Math.PI);
    ctx.arc(123, 66.5, 2, 0, 2 * Math.PI);
    ctx.fillStyle = '#2D788B';
    ctx.fill();
    ctx.restore();
    //nose
    ctx.beginPath();
    ctx.moveTo(230, 205);
    ctx.lineTo(220, 225);
    ctx.lineTo(230, 225);
    ctx.stroke();
    //mouth
    ctx.beginPath();    
    ctx.moveTo(230, 260);
    ctx.bezierCurveTo(200, 255, 205, 240, 240, 250);
    ctx.bezierCurveTo(260, 255, 255, 265, 230, 260);
    ctx.stroke();
    //hat down part
    ctx.beginPath();    
    ctx.scale(2, 0.4);
    ctx.arc(120, 430, 30, 0, 2 * Math.PI);    
    ctx.strokeStyle = '#272B2E';
    ctx.fillStyle = '#396693';
    ctx.fill();
    ctx.stroke();
    //hat upper part
    ctx.restore();
    ctx.beginPath();
    ctx.moveTo(110, 410);
    ctx.lineTo(110, 300);    
    ctx.lineTo(135, 300);    
    ctx.lineTo(135, 410);    
    ctx.quadraticCurveTo(123, 450, 110, 410)    
    ctx.fill();
    ctx.stroke();
    ctx.beginPath();
    ctx.scale(1, 2);    
    ctx.arc(122.5, 150, 12, 0, 2 * Math.PI);
    ctx.fill();
    ctx.stroke();

    //HOUSE
    ctx.strokeStyle = '#000';
    ctx.scale(1,2.3)
    ctx.beginPath()
    ctx.fillStyle = '#975B5B';
    ctx.fillRect(250, 110, 110, 100);    
    ctx.strokeRect(250, 110, 110, 100);
    ctx.moveTo(250, 110);
    ctx.lineTo(305, 10);
    ctx.lineTo(360, 110);
    ctx.fill();
    ctx.stroke();
    //windows
    ctx.fillStyle = "#000";
    ctx.fillRect(255, 120, 22, 15);
    ctx.fillRect(279, 120, 22, 15);
    ctx.fillRect(255, 137, 22, 15);
    ctx.fillRect(279, 137, 22, 15);

    ctx.fillRect(310, 119, 22, 15);
    ctx.fillRect(334, 119, 22, 15);
    ctx.fillRect(310, 136, 22, 15);
    ctx.fillRect(334, 136, 22, 15);

    ctx.fillRect(310, 164, 22, 15);
    ctx.fillRect(334, 164, 22, 15);
    ctx.fillRect(310, 181, 22, 15);
    ctx.fillRect(334, 181, 22, 15);

    //door
    ctx.beginPath();
    ctx.moveTo(260, 210);
    ctx.lineTo(260, 170);
    ctx.bezierCurveTo(265, 160, 289, 160, 294, 170);
    ctx.lineTo(294, 210);
    ctx.moveTo(277, 210);
    ctx.lineTo(277, 162);
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(272, 195, 2, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(282, 195, 2, 0, 2 * Math.PI);    
    ctx.stroke();
    
    //chimney
    ctx.beginPath();
    ctx.moveTo(325, 80);
    ctx.lineTo(325, 30);
    ctx.stroke();
    ctx.save();
    
    ctx.restore();
    ctx.beginPath();
    ctx.moveTo(335, 30);
    ctx.lineTo(335, 80);
    ctx.stroke();

    ctx.lineTo(325, 80);
    ctx.lineTo(325, 30);
    ctx.lineTo(335, 30);
    ctx.fillStyle = '#975B5B';
    ctx.fill();
    ctx.beginPath();
    ctx.scale(1, 0.3);
    ctx.arc(330, 100, 5, 0, 2 * Math.PI);
    ctx.fillStyle = '#975B5B';
    ctx.fill();
    ctx.stroke();
}