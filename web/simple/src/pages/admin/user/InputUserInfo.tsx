import { Button, DatePicker, Input } from "@douyinfe/semi-ui";
import { Component, ReactNode } from "react";
import { IconSearch } from '@douyinfe/semi-icons';

interface IProps {
    keywords: string | undefined,
    startTime: string | null,
    endTime: string | null,
    keywordsChange: any,
    timeChange: any
}

class InputUserInfo extends Component<IProps>{
    render(): ReactNode {
        return (<div>
            <Input onChange={(value) => this.props.keywordsChange(value)} value={this.props.keywords} style={{ width: "200px", marginRight: "8px" }} prefix={<IconSearch />} showClear ></Input>
            <DatePicker onChange={(value) => this.props.timeChange(value)} type="dateRange" density="compact" style={{ width: 260, marginRight: "8px" }} />
            <Button icon={<IconSearch />} aria-label="截屏" />
        </div>)
    }
}

export default InputUserInfo