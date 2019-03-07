import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';
import SanaListaus from './SanaListaus';
import Navigointi from './Navigointi';
import SananLisays from './SananLisays';

ReactDOM.render(
<div>
<Navigointi />
<SanaListaus />
<SananLisays />
</div>
, document.getElementById('root'));

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
