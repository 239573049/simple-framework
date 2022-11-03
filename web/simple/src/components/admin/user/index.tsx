import { Component, ReactNode } from "react";
import userinfoapi from "../../../apis/userinfoapi";
import { GetUserInfoInput } from "../../../modules/userInfo/GetUserInfoInput";
import InputUserInfo from "./InputUserInfo";
import TabUserInfo from "./TabUserInfo";

interface IState {
    input: GetUserInfoInput
}

interface IProps {

}

class UserLayout extends Component<IProps, IState>{
    state: Readonly<IState> = {
        input: {
            keywords: undefined,
            startTime: null,
            endTime: null,
            page: 1,
            pageSize: 20
        }
    }
    render(): ReactNode {
        var { input } = this.state
        return (
            <div>
                <InputUserInfo
                    keywords={input.keywords}
                    startTime={input.startTime}
                    keywordsChange={(value: any) => console.log(value)}
                    timeChange={(value: any) => {
                        input.keywords = value
                        console.log(input);

                        this.setState({
                            input
                        })
                    }}
                    endTime={input.endTime} />
                <TabUserInfo input={null} />
            </div>
        )
    }
}
export default UserLayout