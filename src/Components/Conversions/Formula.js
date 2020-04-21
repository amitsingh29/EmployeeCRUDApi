import React,{Component} from 'react';

class Formula extends Component {
render(){
    return (
        
        <div>
        <label  id='formula-label'>Formula</label>
        {
            (this.props.selectTypeLeft==="Meter" && this.props.selectTypeRight==="Centimeter") ? 
            <p>multiply the length value by 100</p> :
            (this.props.selectTypeLeft==="Centimeter" && this.props.selectTypeRight==="Meter") ?
            <p>divide the length value by 100</p> :
            (this.props.selectTypeLeft==="Kilogram" && this.props.selectTypeRight==="Gram") ?
            <p>multiply the mass value by 1000</p> :
            (this.props.selectTypeLeft==="Gram" && this.props.selectTypeRight==="Kilogram") ?
            <p>divide the mass value by 1000</p> :
            (this.props.selectTypeLeft==="Feet" && this.props.selectTypeRight==="Inch") ?
            <p>multiply the length value by 12</p> : 
            (this.props.selectTypeLeft==="Inch" && this.props.selectTypeRight==="Feet") ?
            <p>divide the length value by 12</p> :null
        }
    </div>
)
}
}
export default Formula;