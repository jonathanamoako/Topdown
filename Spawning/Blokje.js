var Blokje = {
    x:0,
    y:0,
    xStap:0,
    yStap:1,
    breedte: 25,
    height: 25,
    
    update:function()
    {
        this.y += this.yStap;
    },
            
    teken:function(context, plaatje)
    {
    context.drawImage(plaatje,this.x,this.y);
    }
}