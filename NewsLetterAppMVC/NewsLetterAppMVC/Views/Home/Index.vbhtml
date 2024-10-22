﻿<div class="row no-gutters m-3" >
    <div class="card col-sm-12 col-md-10 col-lg-6 mx-auto shadow">
        <div class="card-header text-center ">
            <h5 class="m-0">Sign up to our newsletter</h5>
        </div>
        <div class="card-body">
            @Using (Html.BeginForm("SignUp", "Home", FormMethod.Post))
            End Using
            
                <div class="row no-gutters">
                    <div class="form-group col-md-12">
                        <input name="FirstName" type="text" class="form-control" placeholder="First Name"/>
                    </div>
                    <div class="form-group col-md-12">
                        <input name="LastName" type="text" class="form-control" placeholder="Last Name""/>
                    </div>
                    <div class="form-group col-md-12">
                        <input name="EmailAddress" type="email" class="form-control" placeholder="Email Address" />
                    </div>
                    <button type="submit" class="btn btn-block btn-primary">Submit</button>
                </div>
            

        </div>
    </div>

</div>