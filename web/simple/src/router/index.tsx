import {
    useRoutes
} from 'react-router-dom';
import Admin from '../pages/admin';
import DictionarySettings from '../pages/admin/dictionary-settings/dictionary_settings';
import Home from '../pages/admin/home/';
import Menu from '../pages/admin/menu';
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
                path: "/menu",
                element: <Menu />
            },
            {
                path: "/dictionary-settings",
                element: <DictionarySettings />
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