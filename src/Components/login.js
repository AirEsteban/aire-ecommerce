import React from 'react';
import '../css/login.scss';
import logo from '../images/react2.png';
function Login(){
    return (
        <div className="container">
            <div className="row margin-row">
                <div className="col-4"></div>
                <div className="col-4 box">
                    <div className="box-content">
                    <div className="row">
                        <div className="text-center">
                            <img src={logo} alt="..." className="rounded"/>
                        </div>
                    </div>
                        <div className="mb-3 mt-3 row">
                            <label for="inputUsername" className="login-lbl">Username</label>
                            <div className="col-sm-12">
                                <input type="input" className="form-control login-inp" id="inputUsername" />
                            </div>
                        </div>
                        <br/>
                        <div className="mb-4 row">
                            <label for="inputPassword" className="login-lbl">Password</label>
                            <div className="col-sm-12">
                                <input type="password" className="form-control login-inp" id="inputPassword" />
                            </div>
                        </div>
                        <br/>
                        <div className="mb-1 row">
                            <div className="col-sm-12">
                                <button className="btn btn-info mb-2 form-control">Log In!</button>
                                <span>Don't have an account?<a href="/signup" className="login-lbl"> Sign up</a></span>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="col-4"></div>
            </div>
      </div>
    )
}export default Login;