import React from 'react';
import Login from './login';
import SignUp from './signUp';
import {
    BrowserRouter as Router,
    Link,
    Switch,
    Route
} from 'react-router-dom';

function NavBar(){
    return (
    <Router>
        <nav className="nav-color navbar navbar-expand-lg navbar-light">
            <div className="container-fluid">
                <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span className="navbar-toggler-icon"></span>
                </button>
                <div className="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul className="navbar-nav me-auto mb-2 mb-lg-0">
                        <li className="nav-item">
                            <Link to='/man' className="active nav-color-text" aria-current="page">MAN</Link>
                        </li>
                        <li className="nav-item">
                            <Link to='/woman' className="active nav-color-text" aria-current="page" href="#">WOMAN</Link>
                        </li>
                        <li className="nav-item">
                            <Link to='/kids' className="active nav-color-text" aria-current="page" href="#">KIDS</Link>
                        </li>
                        <li className="nav-item">
                            <Link to='/sport' className="active nav-color-text" aria-current="page" href="#">SPORT</Link>
                        </li>
                        <li className="nav-item">
                            <Link to='/sale' className="active nav-color-text" aria-current="page" href="#">SALE</Link>
                        </li>
                    </ul>
                    <form className="d-flex">
                        <Link to='/signUp'><button href="#" className="btn btn-light mx-2">SIGN UP!</button></Link>
                        <Link to='/login'><button className="btn btn-info" type="submit">LOGIN</button></Link>
                    </form>
                </div>
            </div>
        </nav>
        <Switch>
          <Route exact path="/login">
            <Login />
          </Route>
          <Route exact path="/signUp">
            <SignUp />
          </Route>
        </Switch>
    </Router>
    )
};
export default NavBar;