import React from 'react';
import '../css/login.scss';
import logo from '../images/react2.png';

function SignUp(){
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
                        <div className="mb-3 row">
                            <label htmlFor="inputUsername" className="login-lbl">Username</label>
                            <div className="col-sm-12">
                                <input type="input" className="form-control login-inp" id="inputUsername" />
                            </div>
                        </div>
                        <div className="mb-3 row">
                            <label htmlFor="inputEmail" className="login-lbl">Email</label>
                            <div className="col-sm-12">
                                <input type="email" className="form-control login-inp" id="inputEmail" />
                            </div>
                        </div>
                        <div className="mb-3 row">
                            <label htmlFor="inputPassword" className="login-lbl">Password</label>
                            <div className="col-sm-12">
                                <input type="password" className="form-control login-inp" id="inputPassword" />
                            </div>
                        </div>
                        <div className="mb-5 row">
                            <label htmlFor="inputPasswordConfirm" className="login-lbl">Confirm password</label>
                            <div className="col-sm-12">
                                <input type="password" className="form-control login-inp" id="inputPasswordConfirm" />
                            </div>
                        </div>
                        <div className="row mt-2">
                            <div className="col-sm-12">
                                <button id='confirmCreation' onClick={() => sendUser()} className="btn btn-info mb-3 form-control">Confirm</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="col-4"></div>
            </div>
      </div>
    )
}export default SignUp;

function sendUser(){
    alert("enviado pa");
}