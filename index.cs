
<script src="~/Scripts/jquery-3.4.1.js"></script>
<script src="~/Scripts/jquery-3.4.1.min.js"></script>
<script type="text/javascript">

    $(function () {
        $("#txt").keypress(function (e) {
            if (String.fromCharCode(e.keyCode).match(/[^0-9+-/*]/g)) return false;
        });
        $("#txt").height("40px").width("312px");
        $("#b0").click(function () {
            var x = document.getElementById("txt").value;
            if (x == "0") {
                $("#txt").val("0");
            } else {
                $("#txt").val(x + "0")
            }
        });
        $("#b1").click(function () {
            var x = document.getElementById("txt").value;
            if (x == "0") {
                $("#txt").val("1");
            } else {
                $("#txt").val(x + "1")
            }
        });
        $("#b2").click(function () {
            var x = document.getElementById("txt").value;
            if (x == "0") {
                $("#txt").val("2");
            } else {
                $("#txt").val(x + "2")
            }
        });
        $("#b3").click(function () {
            var x = document.getElementById("txt").value;
            if (x == "0") {
                $("#txt").val("3");
            } else {
                $("#txt").val(x + "3")
            }
        });
        $("#b4").click(function () {
            var x = document.getElementById("txt").value;
            if (x == "0") {
                $("#txt").val("4");
            } else {
                $("#txt").val(x + "4")
            }
        });
        $("#b5").click(function () {
            var x = document.getElementById("txt").value;
            if (x == "0") {
                $("#txt").val("5");
            } else {
                $("#txt").val(x + "5")
            }
        });
        $("#b6").click(function () {
            var x = document.getElementById("txt").value;
            if (x == "0") {
                $("#txt").val("6");
            } else {
                $("#txt").val(x + "6")
            }
        });
        $("#b7").click(function () {
            var x = document.getElementById("txt").value;
            if (x == "0") {
                $("#txt").val("7");
            } else {
                $("#txt").val(x + "7")
            }
        });
        $("#b8").click(function () {
            var x = document.getElementById("txt").value;
            if (x == "0") {
                $("#txt").val("8");
            } else {
                $("#txt").val(x + "8")
            }
        });
        $("#b9").click(function () {
            var x = document.getElementById("txt").value;
            if (x == "0") {
                $("#txt").val("9");
            } else {
                $("#txt").val(x + "9")
            }
        });
        $("#div").click(function () {
            var x = document.getElementById("txt").value;
            var y = x.slice(-1)
            if (y == "/" || y == "+" || y == "*" || y == "-") { } else {
                $("#txt").val(x + "/")
            }
        });
        $("#multy").click(function () {
            
            var x = document.getElementById("txt").value;
            var y = x.slice(-1)
            if (y == "/" || y == "+" || y == "*" || y == "-") { } else {
                $("#txt").val(x + "*")
            }
        });
        $("#sub").click(function () {
           
            var x = document.getElementById("txt").value;
            var y = x.slice(-1)
            if (y == "/" || y == "+" || y == "*" || y == "-") { } else {
                $("#txt").val(x + "-")
            }
        });
        $("#add").click(function () {
            
            var x = document.getElementById("txt").value;
            var y = x.slice(-1)
            if (y == "/" || y == "+" || y == "*" || y == "-") { } else {
                $("#txt").val(x + "+")
            }
        });
        $("#dot").click(function () {
            var x = document.getElementById("txt").value;
            var y = x.slice(-1)
            if (y == ".") { } else {
                $("#txt").val(x + ".")
            }
        });
        $("#ce").click(function () {
            var x = document.getElementById("txt").value;
            $("#txt").val(x.substring(0, x.length - 1))
        });
    });
</script>
<style>
    body {
        background-image: url("Image/images.jpg");
    }

    #d1 {
       
        height: 340px;
        width: 350px;
       
        
    }
    #formDetails {
        
        height: 340px;
        width: 340px;
       background-color:lightgray;
    }
</style>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<center>
    <div id="d1">
        @using (@Html.BeginForm("Index", "Calculator"))
        {
            <table style="height:25%;border:thick;background-color:lightgrey ">
               
                <tr class="p-5">
                    <td colspan="4">@Html.TextBox("txt", (string)ViewBag.result)</td>
                </tr>
                <tr>
                    <td><input type="button"  class="btns" id="b7" value="7" style="height:40px;width:75px" /></td>
                    <td><input type="button" class="btns" id="b8" value="8" style="height:40px;width:75px" /></td>
                    <td><input type="button" class="btns"  id="b9" value="9" style="height:40px;width:75px" /></td>
                    <td><input type="button"class="btns"  id="div" value="/" style="height:40px;width:75px" /></td>
                </tr>
                <tr>
                    <td><input type="button"  class="btns" id="b4" value="4" style="height:40px;width:75px" /></td>
                    <td><input type="button"  class="btns" id="b5" value="5" style="height:40px;width:75px" /></td>
                    <td><input type="button"  class="btns" id="b6" value="6" style="height:40px;width:75px" /></td>
                    <td><input type="button" class="btns" id="multy" value="*" style="height:40px;width:75px" /></td>
                </tr>
                <tr>
                    <td><input type="button" class="btns"  id="b1" value="1" style="height:40px;width:75px" /></td>
                    <td><input type="button" class="btns"  id="b2" value="2" style="height:40px;width:75px" /></td>
                    <td><input type="button"  class="btns" id="b3" value="3" style="height:40px;width:75px" /></td>
                    <td><input type="button" class="btns" id="sub" value="-" style="height:40px;width:75px" /></td>
                </tr>
                <tr>
                    <td><input type="button" class="btns" id="b0" value="0" style="height:40px;width:75px" /></td>
                    <td><input type="button"  class="btns" id="dot" value="." style="height:40px;width:75px" /></td>
                    <td><input type="button" class="btns" id="add" value="+" style="height:40px;width:75px" /></td>
                    <td><input type="submit" class="btns" id="eq" value="=" style="height:40px;width:75px" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <input type="button" class="btns" id="ce" value="CE" style="height:40px;width:155px" />
                    </td>
                    <td colspan="2">
                        <input type="reset" class="btns" id="re" value="Clear" style="height:40px;width:155px" />
                    </td>
                </tr>
                
            </table>
        }
    </div>
</center>
@if (@ViewBag.flag == 0)
{
    Response.Write("");
<script>
    alert('Right value is missing.')
</script>

}
