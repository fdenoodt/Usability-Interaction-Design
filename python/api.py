from flask import Flask, request

app = Flask(__name__)
app.config["DEBUG"] = True


@app.route('/', methods=['GET'])
def home():
    length = request.args.get('length')
    power = request.args.get('power')
    return "<h1>Success</h1> Length:" + length + ", power: " + power

app.run()
# host='0.0.0.0', 