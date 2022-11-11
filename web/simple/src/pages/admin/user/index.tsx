import { Component, ReactNode } from "react";
import { GetUserInfoInput } from "../../../modules/userInfo/GetUserInfoInput";
import InputUserInfo from "../../../components/admin/user/InputUserInfo";
import TabUserInfo from "../../../components/admin/user/TabUserInfo";
import moment from 'moment';
import React from "react";

interface IState {
    input: GetUserInfoInput;
    tabUserInfoRef: any
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
        },
        tabUserInfoRef: React.createRef()
    }
    onRef(value: any) {
        console.log(value);

        this.setState({
            tabUserInfoRef: value
        })
    }



    render(): ReactNode {
        var { input } = this.state
        return (
            <div>
                <InputUserInfo
                    keywords={input.keywords}
                    startTime={input.startTime}
                    OnClick={() => {
                        this.state.tabUserInfoRef.getUserInfo();
                    }}
                    keywordsChange={(value: any) => {
                        input.keywords = value
                        this.setState({
                            input
                        })
                    }}
                    timeChange={(value: any) => {
                        input.startTime = moment(value[0]).format("YYYY-MM-DD HH:mm:ss")
                        input.endTime = moment(value[1]).format("YYYY-MM-DD HH:mm:ss")
                        this.setState({
                            input
                        })
                    }}
                    endTime={input.endTime} />
                <TabUserInfo input={input} onRef={(value: any) => this.onRef(value)} inputonChange={(value: any) => {
                    this.setState({
                        input: value
                    })
                }} />
            </div>
        )
    }
}
export default UserLayout
