import React, { Component } from 'react';
class QuantityLeft extends Component{
    
    render(){
        return(
            <div className="input-div-left">
                <input type='text' className="input-label-left" onChange={this.props.inputTypeLeft} />
                <select className='form-control-left' onChange={this.props.selectTypeLeft}>
                <option value="-1" selected>Select</option>
                
                {
                    this.props.showType?
                    <>
                <option name="length">Feet</option>
                <option name="weight">Inch</option>
                <option name="weight">Meter</option>
                <option name="weight">Centimeter</option></> : <>
                <option name="weight">Kilogram</option>
                <option name="weight">Gram</option>
                </>
                }
                </select>
            </div>
        )
    }
}
export default QuantityLeft;