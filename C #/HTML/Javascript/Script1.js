// JavaScript source code
function sum1()
	{
if(frmCalc.txtFirstNo.value=="")
	{
	document.getElementById("err1").innerHTML="Please enter first number";
	return;
	}
	else
	{
	document.getElementById("err1").innerHTML="";
	}
	if(frmCalc.txtSecondNo.value=="")
	{
	document.getElementById("err2").innerHTML="Please enter second number";
	return;
	}
	else
	{
	document.getElementById("err2").innerHTML="";
	}	
	var a,b,c;
	a=parseInt(frmCalc.txtFirstNo.value);
	b=parseInt(frmCalc.txtSecondNo.value);
	c=a+b;
	frmCalc.txtResult.value=c;
}
function sub1()
{
	var a,b,c;
	a=parseInt(frmCalc.txtFirstNo.value);
	b=parseInt(frmCalc.txtSecondNo.value);
	c=a-b;
	frmCalc.txtResult.value=c;
}
function Mult1()
{
	var a,b,c;
	a=parseInt(frmCalc.txtFirstNo.value);
	b=parseInt(frmCalc.txtSecondNo.value);
	c=a*b;
	frmCalc.txtResult.value=c;
}
