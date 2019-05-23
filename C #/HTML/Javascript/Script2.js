// JavaScript source code
function login()
{
	var user,pwd;
	user=frmLogin.txtUser.value;
	pwd=frmLogin.txtPassword.value;
	if(user=="Arun" && pwd=="Arun")
	{
		window.open("Menupage.html",'_new','location=0.status=1,'+ + 'toolbar=0,menuBar=0,scrollBars=0,directories=0,'+ +'resizable=0,width=150,height=150');
	}
	else
	{
	alert("Invalid credentials...");
	}
}