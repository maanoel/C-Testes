<!DOCTYPE html>
<html>
<body>

<h1>JavaScript Strings</h1>
<h2>The replace() Method</h2>

<p>replace() searches a string for a value,
and returns a new string with the specified value(s) replaced:</p>

<p id="demo">Mr Blue has a blue house and a blue car.</p>

<script>
let str = document.getElementById("demo").innerHTML; 
let res = str.replace(/blue/g, "red");
let res2 = res.replace(/red/g, "blue");
let res3 = res2.replace(/blue/g,"purple");
document.getElementById("demo").innerHTML = res3;
</script>

</body>
</html>
