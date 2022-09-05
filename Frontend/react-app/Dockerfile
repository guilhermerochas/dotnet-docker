FROM node:16-alpine

WORKDIR /app

ENV PATH /app/node_modules/.bin:$PATH

COPY package.json .

COPY yarn.lock .

RUN yarn add node-sass

RUN yarn

COPY . .

CMD ["yarn", "start"]
