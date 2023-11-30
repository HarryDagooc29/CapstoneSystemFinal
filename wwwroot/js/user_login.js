$(()=>{
    localStorage.clear()
    const login_form = $("#login-form")
    const input_fields = login_form.find("input")
    const login_btn = $("#submit-login")
    const dataToPost = {}
    
    const checkInputs = () =>{
        const allFilled = input_fields.toArray().every(input => {
            return $(input).val() !=="";
        })

        login_form.serializeArray().forEach(item=>{
            dataToPost[item.name] =  item.value
        })
        console.log(dataToPost)
        if(allFilled){
            login_btn.css({
                "opacity":"1",
                "cursor":"pointer",
                "pointer-events":"initial"
            })
        }else{
            login_btn.css({
                "opacity":"0.54",
                "cursor":"not-allowed",
                "pointer-events":"none"
            })
        }
    }
    input_fields.on("keyup", checkInputs)
    checkInputs()

    login_btn.click(e=>{
        e.preventDefault()
        $.ajax({
            method:"POST",
            url:"/api/client/login",
            data:dataToPost
        }).done(res=>{
            if(res !== "User account not found!"){
                localStorage.setItem("userId", res['userId'])
                localStorage.setItem("acc_firstname", res['firstName'])
                localStorage.setItem("acc_role", res['accountRole'])
                window.location.href = "http://localhost:5165/home"
            }else{
                Swal.fire({
                    icon: 'error',
                    title: 'Oops, Something Went Wrong',
                    text: res,
                    toast: true,
                    position: 'top-end',
                    showConfirmButton: false,
                    timer: 3000,
                    customClass: {
                      container: 'swal-container',
                      popup: 'swal-popup',
                      icon: 'swal-icon',
                      title: 'swal-title',
                      text: 'swal-text',
                    },
                    showClass: {
                      popup: 'animate__animated animate__fadeInRight',
                    },
                    hideClass: {
                      popup: 'animate__animated animate__fadeOutRight',
                    },
                });
                  
            }
        })
    })
})