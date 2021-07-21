import React from 'react';
import Login from './login';
import {
    BrowserRouter as Router,
    Link,
    Switch,
    Route
} from 'react-router-dom';

function NavBar(){
    return (
    <Router>
        <div className='nav-color'>
            <nav className="navbar navbar-expand-lg navbar-light">
                <div className="container-fluid">
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
                        <form class="d-flex">
                            <Link to='/login'><button class="btn btn-info" type="submit">LOGIN</button></Link>
                        </form>
                    </div>
                </div>
            </nav>
        </div>
        <Switch>
          <Route exact path="/login">
            <Login />
          </Route>
        </Switch>
    </Router>
    )
};
export default NavBar;