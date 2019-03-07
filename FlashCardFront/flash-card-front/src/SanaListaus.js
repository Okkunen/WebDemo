import React, { Component } from 'react';

class SanaListaus extends Component {

    constructor(props) {
        super(props);
        console.log("SanaListaus.constructor");
        this.state = { ladattu: false, data: null };
    }

    componentDidMount() {
        console.log("SanaListaus.componentDidMount");
        let komponentti = this;

        fetch('https://localhost:44356/api/kortit')
            .then(response => response.json())
            .then(json => {
                console.log("Fetch-kutsu valmis!");
                console.log(json);

                komponentti.setState({ ladattu: true, data: json });
                console.log("setState-rutiinia kutsuttu");
            });

        console.log("SanaListaus.componentDidMount: fetch-kutsu tehty");
    }

    render() {
        console.log("SanaListaus.render");
        if (this.state.ladattu === false) {
            return (
                <div>
                    <h1>Odota, ladataan tietoja...</h1>
                </div>
            );
        } else {
            return (
                <div className="container">
                    <table className="table">
                        <thead>
                            <tr>
                                <th>Sana</th>
                                <th>Kaannos</th>
                            </tr>
                        </thead>
                        <tbody>
                            {this.state.data.map((data, i) => {
                                return (
                                    <tr key={i}>
                                        <td>{data.sana}</td>
                                        <td>{data.kaannos}</td>
                                    </tr>
                                )
                            })}
                        </tbody>
                    </table>
                </div>
            );
        }
    }
}
export default SanaListaus;