import {
    useRoutes
} from 'react-router-dom';
import Admin from '../pages/admin';
import Home from '../pages/admin/home/';
import User from '../pages/admin/user';
import Login from '../pages/user/login';

const Routes = () => {
    const router = useRoutes([{
        path: "/",
        element: <Admin />,
        children: [
            {
                path: "/",
                element: <Home />
            },
            {
                path: "/user",
                element: <User />
            }]
    }, {
        path: "/login",
        element: <Login />
    }])

    return router
}

export default Routes