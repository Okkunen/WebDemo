import React, { Component } from 'react';

class SananLisays extends Component {

    lisaaSana() {

        let data = 
        {
            "sana" : "jotain",
            "kaannos" : "jotainmuuta"
        };

        let url = "https://localhost:44356/api/kortit";
        fetch(url, {
            method: "POST",
            mode: "cors",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(data),
        });

        alert("Fetch-pyyntö lähetetty!");
    }

    render() {
        return (
            <div>
                <button onClick={this.lisaaSana} type="button" className="btn btn-primary">Lisää sana</button>
            </div>
        );
    }
}

export default SananLisays;