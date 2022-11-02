import { Component, ReactNode } from "react";
import userinfoapi from "../../../apis/userinfoapi";
import InputUserInfo from "./InputUserInfo";
import TabUserInfo from "./TabUserInfo";

class UserLayout extends Component {
    render(): ReactNode {
        return (
            <div>
                <InputUserInfo />
                <TabUserInfo input={null} />
            </div>
        )
    }
}
export default UserLayout