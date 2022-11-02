import { Button, DatePicker, Input } from "@douyinfe/semi-ui";
import { Component, ReactNode } from "react";
import { IconSearch } from '@douyinfe/semi-icons';

class InputUserInfo extends Component {
    render(): ReactNode {
        return (<div>
            <Input style={{ width: "200px", marginRight: "8px" }} prefix={<IconSearch />} showClear ></Input>
            <DatePicker type="dateRange" density="compact" style={{ width: 260, marginRight: "8px" }} />

            <Button icon={<IconSearch />} aria-label="截屏" />
        </div>)
    }
}

export default InputUserInfo