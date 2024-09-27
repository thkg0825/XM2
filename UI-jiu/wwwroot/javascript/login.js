$(function() {
	$(":button").click(function () {
		console.log("按钮")
		doLogin();
	});
	$("html").die().live("keydown", function(event) {
		if (event.keyCode == 13) {
			console.log("键盘")
			doLogin();
		}
	});
});

function doLogin() {
	var userName = $("#userName");
	var userPassword = $("#userPassword");
	var reg = /^\S{3,}$/;
	if (!reg.test(userName.val())) {
		userName[0].select();
		$.messager.show("消息提示", "登录名格式不正确！长度必须大于3位且不能有空格！", 2000);
		return false;
	}
	if (!reg.test(userPassword.val())) {
		userPassword[0].select();
		$.messager.show("消息提示", "登录密码格式不正确！长度必须大于3位且不能有空格！", 2000);
		return false;
	}
	location.href = '/HR/Main';
}