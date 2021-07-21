import React from 'react';
import '../css/login.scss';
import logo from '../images/react2.png';
function Login(){
    return (
        <div class="container">
            <div class="row margin-row">
                <div class="col-4"></div>
                <div class="col-4 box">
                    <div class="box-content">
                    <div class="row">
                        <div class="text-center">
                            <img src={logo} alt="..." class="rounded"/>
                        </div>
                    </div>
                        <div class="mb-3 mt-3 row">
                            <label for="inputUsername" class="login-lbl">Username</label>
                            <div class="col-sm-12">
                                <input type="input" class="form-control login-inp" id="inputUsername" />
                            </div>
                        </div>
                        <br/>
                        <div class="mb-5 row">
                            <label for="inputPassword" class="login-lbl">Password</label>
                            <div class="col-sm-12">
                                <input type="password" class="form-control login-inp" id="inputPassword" />
                            </div>
                        </div>
                        <br/>
                        <div class="mb-5 row">
                            <button class="btn btn-info mb-3">Log In!</button>
                            <span>Don't have an account?<a href="/signup" class="login-lbl"> Sign up</a></span>
                        </div>
                    </div>
                </div>
                <div class="col-4"></div>
            </div>
      </div>
    )
}export default Login;