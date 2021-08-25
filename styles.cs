
body
{
    font-family:'Avenir-Next','Roboto', sans-serif;
    font-size: 16px;
    margin: 0;
}

.section1,.section2,.section3,.section4,.section5,.section6,.section7,.section8,.section9,.section10,.section11,.section12,.section13,.section14,.section15,footer{
    margin-right: 10px;
}


/* nav{
    padding-bottom: 0;
    margin-bottom: 0;
    padding-top: 0;
    margin-top: 0;
} */

.logo{
    width: 150px;
    height:50px
}

.nav-flex
{
    display: flex;
    justify-content: space-between;
    align-items: center;
}
.nav2-flex
{
    display: flex;
    justify-content: space-around;
    align-items: center;
    gap: 10px;
}


header ul
{
    list-style: none;
}


.flag{
    
    width: 3%;
    height: 70%;
}
header a
{
    text-decoration: none;
    
}
.atags
{
    color: gray;
    font-weight: 600;
    font-size: 95%;
}

select
{
   border: none;
    outline: none;
    font-weight: bold;
    color: gray;
    font-size: 90%;
    
}


@media (min-width:900px) {

    .hamburger
    {
        display: none;
        
    }
    
}

@media (max-width:900px)
{
    select,.atags,.flag
    {
        display: none;
    }

    header{
        margin-right: 10px;
    }
}

.apply{
    background-color: #fa5914;
    width: 100px;
    text-align: center;
    
}

/* Section-1 styling */
.container
{
    margin-left:10%;
    margin-right:10%;
}
.section1
{
    background-image:url("https://i.imgur.com/ksqOx5F.jpeg");
    margin-top: 0;
    padding-bottom: 50px;
    margin-right: 10px;
    position: relative;
    /* padding-top: 50px; */
    
}

.section1 .heading
{
    font-size: 90px;
    font-weight:900;
    text-shadow: 3px 0px white;
    color: white;
    width: 80%;
    margin-bottom: 0;
    margin-top: 0;
    padding-top: 60px;
}

.section1 .subheading
{
    font-size: 33px;
    color: white;
    font-weight: bold;
    margin-top: 0;
}

.apply-btn
{
    background-color: #4992ca;
    border: none;
    color: white;
    width: 180px;
    height: 35px;
}

.register-btn
{
    background-color: transparent;
    color: white;
    border:1px solid white;
    width: 180px;
    height: 35px;
    margin-top: 10px;
    border-radius: 2px;
}

.learn-btn
{
    background-color: white;
    border: none;
    border-radius: 15px;
    height: 40px;
    margin-top: 10px;
    margin-bottom: 30px;
}

.overlay {
    height:100%;
    width:100%;
    background-color:#000000b3;
    position:absolute;
    opacity:0.9;
    }

.z-index-content{
    z-index: 1;
    position: relative;
}

@media (max-width:500px) {

    .section1 .heading
    {
        font-size: 40px;
        /* width: 100%; */
    }

    .nav2-flex{
        display: none;
    }
}


.section2{
    color: white;
    background-color: #4992ca;
    margin-right: 10px;
    
}

.heading2{
    font-size:45px;
    padding-top: 10px;
    margin-top: 0px;
    margin-bottom: 10px;
    text-align: center;
    text-shadow: 1px 0px white;
}

.content2{
    font-size: 19px;
    text-align: center;
    /* font-weight: bold; */
}

@media (max-width:400px){
    .heading2{
        /* text-shadow: none; */
        font-size: 30px;
    }

    .content2{
        font-size: 14px;
        
    }
}

.section2 h4{
    font-size:30px;
    text-align: center;
    margin-bottom:20px;
    margin-top: 20px;
    /* margin-left: 40%; */
}

.col{
    width: 300px;
}

.pokemon-types{
    display: flex;
    justify-content: space-around;
    flex-wrap: wrap;
    /* gap: 10px; */
    align-items: center;
    
}

.icon
{
    font-size: 40px;
    text-align: center;
    margin-left: 45%;
}

.poktype{
    margin-bottom:60px;
}

.section3 h4{
    font-size: 30px;
}

.section3 h2{
    font-size: 45px;
    
}

.heading3{
    text-align: center;
    text-shadow: 2px 0px black;
    margin-bottom: 0;

}

.flex-content1{
    display: flex;
    justify-content: space-around;
    flex-wrap: wrap;
    gap:50px;
    
}

.subheading3{
    margin-top: 0;
    text-shadow: 1px 0px black;
}

.col3{
    text-align: center;
    width: 450px;
}

.section3 p{
    font-weight: bold;
}

@media (max-width:500px) {
    

    .col3{
        width: 100%;
    }

    .section3 img{
        width: 100%;
    }

    .section3 h2{
        font-size: 35px;
    }
    
}


.section4{
    font-weight: 100;
    
}

.section4 h4{
    font-size: 30px;
    margin-top: 0;
    margin-bottom: 0;
    font-weight: 100;
}

.section4 h6{
    font-size: 18px;
    margin-top: 0;
    margin-bottom: 0;
    font-weight: 100;

}

.heading4{
    text-align: center;
    text-shadow: 2px 0px black;
    margin-bottom: 30px;
    font-size: 45px;
}

.poktype{
    width:100px;
    height: 100px;
    margin-bottom: 15px;
}

.pokemonLogo
{
    width: 150px;
}

.grid-section4{
    /* min-width: 750px; */
    /* display: grid;
    grid-template-columns: 1fr 1fr 3fr; */
    display: flex;
    /* justify-content: space-around; */
    /* flex-wrap: wrap; */
    gap: 60px;
    margin-bottom: 30px;
}

/* .section4 p{ */
    /* min-width: 200px; */
/* } */



@media (max-width:800px){

    .grid-section4{
        flex-wrap: wrap;
        justify-content: space-around;
        gap: 0;
    }

    .middle{
        text-align: center;
    }

    .heading4{
        font-size: 35px;
    }
}

@media (max-width:330px)
{
    .middle{
        margin-top: 15px;
    }
}

.section5{
    background-color: #4992ca;
    color: white;
    padding-top: 30px;
    padding-bottom: 30px;
}

.heading5{
    text-shadow: 2px 0px white;
    font-size: 45px;
    margin-bottom: 0;
    text-align: center;
    

}

.subheading5{
    font-size: 20px;
    font-weight: bold;
    margin-top: 10px;
}

.section5 li{
    font-size: 14px;
    line-height: 25px;
}

.section6 table,td,th
{
    border: 1px solid #8a8a8a;
    border-collapse: collapse;
}

table{
    overflow-x: auto;
}

th{
    font-weight: bold;
    font-size: 20px;
    text-shadow: 1px 0px black;
}

th,td{
    height: 50px;
    text-align: center;
    
    
}

td{
    color: #8a8a8a;
    font-weight: bold;
}

.one{
    width: 15%;
}
.two{
    width: 20%;
}

.three{
 
   width:30%;
}

.four{
    width: 20%;
}

.heading6{
    text-shadow: 2px 0px black;
    font-size: 45px;
    margin-bottom: 0;
    text-align: center;
    margin-bottom: 20px;
}

.subheading6{
    text-align: center;
    font-size: 16px;
    font-weight: bold;
    text-shadow: 1px 0px black;
    margin-top: 0;
}

.section6 p{
    color:#8a8a8a
}

.flex-col-1
{
    width: 500px; 
}

.flex-col-1
{
    flex: 1 2;
}

.flex-col-2
{
    flex:2 1;
}


.flex6
{
    display: flex;
    justify-content: space-around;
    gap: 30px;
    flex-wrap: wrap;
    
    
}


.subheadinglast{
    /* text-align: center; */
    font-size: 16px;
    font-weight: bold;
    text-shadow: 1px 0px black;
    margin-top: 0;
}

.flex-col-1 p{
    line-height: 30px;
}

@media (max-width:940px) {

    

    .flex-col-1{
        
        flex: initial;
        /* min-width: none; */
    }
    
}

@media (max-width:400px)
{
    table,td,th{
        font-size:8px;
    }
}


.section7{
    background-color: #424242;
    padding-top: 20px;
    padding-bottom: 40px;
    margin-top: 20px;
}

.section7 h2{
    font-size: 45px;
    color: white;
    font-weight: bold;
    text-align: center;
    text-shadow: 1px 0px white;
    /* margin-top: 0; */
}

.section7 button{
    background-color: transparent;
    border: 2px solid white;
    width: 200px;
    height: 40px;
    color: white;
}



/* .flex-col-1
{
    flex: 1 2;
}

.flex-col-2
{
    flex: 1 2;
} */

.heading8{
    color: #999393;
    text-align: center;
    text-shadow: 2px 0px #999393;
    font-size: 25px;
}

.card8{
    width:200px;
    /* height: 300px; */
    text-align: center;
    border: 1.5px solid #e4ebf7;
    border-top: 15px solid #4992ca;
    margin: auto;
}

.section9{
    color: white;
    background-color: #4992ca;
    font-weight: 100;
}

.section9 h4{
    font-size: 30px;
}

.section9 h6{
    font-size: 18px;
}

.heading9
{
    text-align: center;
    text-shadow: 2px 0px white;
    margin-bottom: 30px;
    font-size: 45px;
    padding-top: 20px
}

.middle9{
    text-align: center;
}

.Gcard{
    border: 1.5px solid #ebebeb;
    border-top: 15px solid #4992ca;
    text-align: left;
    width: 380px;
}

.cardheading{
    margin-top: 0;
    font-weight: bold;
    text-shadow: 1px 0px black;
    font-size: 30px;

    padding-top: 10px;
    padding-left: 10px;
}

.cards_container{
    display: flex;
flex-wrap: wrap;
justify-content: center;
gap: 10px;

}

.date{
    font-weight: bold;
    padding-bottom:30px ;
    padding-left: 10px;
    margin-bottom: 0;
}

.card-content{
    font-weight: bold;
    line-height: 30px;
    padding:10px;
}

@media (max-width:414px)
{
    .heading10{
        font-size: 15px;
        text-shadow: 1px 0px #999393;
    }
}

.section11{
    background-color: #424242;
}

.section11 .inputf{
    width: 30%;
    height: 35px;
}

.inputbtn
{
    text-align: center;
}

.game_container
{
    display: flex;
    justify-content:center;
    flex-wrap: wrap;
    gap:5%;
}

.section12 img{
    width: 180px;
    height: 200px;
}

.game1 img
{
    width: 230px;
}

.game2 img{
    width: 150px;
}

.game1,.game2,.game3{
    width: 290px;
    text-align: center;
}

.bold
{
    font-weight: bold;
    text-shadow: 1px 0px black;
}

.icon2{
    font-size: 20px;
    margin-left: 0;
    padding-left: 0;
    align-self: center;
}

.innerflex{
    display: flex;
    gap: 3px;
    justify-content: center;

}

@media (max-width:750px) {
    
    .game1,.game2,.game3{
        margin-bottom: 20px;
    }

}


.section13{
    background-color: #4492ca;
    padding-top: 5px;
    margin-top: 10px;
    color: white;
    /* font-weight: bold; */
}

.head13{
    color: white;
    text-align: center;
    text-shadow: 2px 0px #999393;
    font-size: 30px;
}

.flex13 img{
    border-radius: 50%;
    width: 200px;
    
}

.flex13{
    display: flex;
    gap: 5%;
    flex-wrap: wrap;
    justify-content: space-around;

}

.designer{
    width:300px;
}

@media (max-width:800px) {
    .designer{
        margin-bottom: 15px;
    }
}

.heading14{
    letter-spacing: 5px;
    font-size: 40px;
    margin-bottom: 0;
}

.flex-items{
    width: 300px;
    text-align: center;
}
.flex14 img{
    width: 200px;
}

.flex14{
    display: flex;
    justify-content: center;
    gap:auto;
    flex-wrap: wrap;
}

@media (max-width:740px) {
    
    .flex14 img{
        width: 100%;
    }
}

@media (max-width:280px) {
    
    .heading14{
        font-size: 30px;
    }
}

 .section15{
    background-color: #4492ca;
    padding-bottom: 20px;
    padding-top:5px;
    margin-top: 10px;
}

.section15 h2{
    font-size: 45px;
    color: white;
    font-weight: bold;
    text-align: center;
    text-shadow: 1px 0px white;
}

.section15 button{

    background-color: transparent;
    border: 2px solid #fff;
    width: 200px;
    height: 40px;
    color: white;
}

footer{
    font-weight: bold;
    background-color: #292929;

}

footer ul{
    list-style: none;
    text-align: center;
    padding:0;
}
footer li{
    margin-bottom: 11px;
    color: white;
    padding: 0;
}

.flex16{
    display: flex;
    justify-content: space-around;
    flex-wrap: wrap;
}


footer ul{
    width: 200px;
}

.socialicon{
    margin-left: 10%;
    margin-right: 10%;
}

@media (max-width:1050px) {

    .flex16{
        justify-content: center;
    }
    
}

footer a{
    text-decoration: none;
    color: inherit;
}
