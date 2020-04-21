import React, { Component } from 'react';
class QuantityRight extends Component{
    render(){
        return(
            <div className='input-div-right'>
                <input type='text' className="input-label-right" onChange={this.props.inputTypeRight} value={this.props.valueRight} />
                <select  className='form-control-right'  onChange={this.props.selectTypeRight}>
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
export default QuantityRight;