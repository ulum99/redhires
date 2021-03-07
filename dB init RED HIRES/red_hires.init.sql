--
-- PostgreSQL database dump
--

-- Dumped from database version 9.6.20
-- Dumped by pg_dump version 9.6.20

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: ad_user; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ad_user (
    ad_user_id numeric(10,0) NOT NULL,
    ad_client_id numeric(10,0) NOT NULL,
    ad_org_id numeric(10,0) NOT NULL,
    codekey character varying(50) NOT NULL,
    name character varying(255) NOT NULL,
    description character varying(255) DEFAULT NULL::character varying,
    password character varying(50) NOT NULL,
    isactive character(1) DEFAULT 'Y'::bpchar NOT NULL
);


ALTER TABLE public.ad_user OWNER TO postgres;

--
-- Name: roger_batch_roger_batch_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.roger_batch_roger_batch_id_seq
    START WITH 5
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.roger_batch_roger_batch_id_seq OWNER TO postgres;

--
-- Name: batch; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.batch (
    id integer DEFAULT nextval('public.roger_batch_roger_batch_id_seq'::regclass) NOT NULL,
    created timestamp without time zone NOT NULL,
    sent timestamp without time zone,
    sendconfirmed timestamp without time zone,
    description character varying(255) DEFAULT NULL::character varying,
    blockcodecount integer DEFAULT 0 NOT NULL,
    qty integer DEFAULT 0 NOT NULL,
    endqueue integer DEFAULT 10 NOT NULL,
    printedqty integer DEFAULT 0 NOT NULL,
    batchno character varying(50),
    printerlineid integer DEFAULT 0 NOT NULL,
    createdby numeric(10,0) DEFAULT (0)::numeric NOT NULL,
    updated timestamp without time zone DEFAULT now() NOT NULL,
    updatedby numeric(10,0) DEFAULT (0)::numeric NOT NULL,
    productid integer NOT NULL,
    isactive boolean
);


ALTER TABLE public.batch OWNER TO postgres;

--
-- Name: product; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.product (
    name character varying(255) NOT NULL,
    received timestamp without time zone,
    description character varying(255) DEFAULT NULL::character varying,
    upc character varying(30),
    maxbuffer integer DEFAULT 0 NOT NULL,
    localminlevel integer DEFAULT 0 NOT NULL,
    localmaxlevel integer DEFAULT 1000000 NOT NULL,
    codekey character varying(45) NOT NULL,
    endqueue integer,
    availableqty integer DEFAULT 0 NOT NULL,
    isactive boolean DEFAULT true NOT NULL,
    id integer NOT NULL,
    cardboardwidth numeric,
    cardboardlength numeric,
    widthallowance numeric
);


ALTER TABLE public.product OWNER TO postgres;

--
-- Name: product_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.product_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.product_id_seq OWNER TO postgres;

--
-- Name: product_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.product_id_seq OWNED BY public.product.id;


--
-- Name: uniquecode; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.uniquecode (
    productid integer DEFAULT NULL::numeric,
    uniquecode character varying(15) DEFAULT ''::character varying NOT NULL,
    printed timestamp without time zone,
    received timestamp without time zone DEFAULT now() NOT NULL,
    batchid integer DEFAULT NULL::numeric,
    sent timestamp without time zone,
    sendconfirmed timestamp without time zone,
    buffered timestamp without time zone,
    printerlineid integer DEFAULT NULL::numeric,
    markingprinterid integer DEFAULT NULL::numeric,
    id integer NOT NULL,
    isactive boolean DEFAULT true NOT NULL
);


ALTER TABLE public.uniquecode OWNER TO postgres;

--
-- Name: uniquecode_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.uniquecode_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.uniquecode_id_seq OWNER TO postgres;

--
-- Name: uniquecode_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.uniquecode_id_seq OWNED BY public.uniquecode.id;


--
-- Name: product id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product ALTER COLUMN id SET DEFAULT nextval('public.product_id_seq'::regclass);


--
-- Name: uniquecode id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uniquecode ALTER COLUMN id SET DEFAULT nextval('public.uniquecode_id_seq'::regclass);


--
-- Data for Name: ad_user; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.ad_user (ad_user_id, ad_client_id, ad_org_id, codekey, name, description, password, isactive) FROM stdin;
\.


--
-- Data for Name: batch; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.batch (id, created, sent, sendconfirmed, description, blockcodecount, qty, endqueue, printedqty, batchno, printerlineid, createdby, updated, updatedby, productid, isactive) FROM stdin;
\.


--
-- Data for Name: product; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.product (name, received, description, upc, maxbuffer, localminlevel, localmaxlevel, codekey, endqueue, availableqty, isactive, id, cardboardwidth, cardboardlength, widthallowance) FROM stdin;
\.


--
-- Name: product_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.product_id_seq', 1, true);


--
-- Name: roger_batch_roger_batch_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.roger_batch_roger_batch_id_seq', 5, false);


--
-- Data for Name: uniquecode; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.uniquecode (productid, uniquecode, printed, received, batchid, sent, sendconfirmed, buffered, printerlineid, markingprinterid, id, isactive) FROM stdin;
\.


--
-- Name: uniquecode_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.uniquecode_id_seq', 1, true);


--
-- Name: uniquecode UniqueCode_Key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uniquecode
    ADD CONSTRAINT "UniqueCode_Key" PRIMARY KEY (id);


--
-- Name: ad_user ad_user_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ad_user
    ADD CONSTRAINT ad_user_pkey PRIMARY KEY (ad_user_id);


--
-- Name: product product_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.product
    ADD CONSTRAINT product_pkey PRIMARY KEY (id);


--
-- Name: batch roger_batch_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.batch
    ADD CONSTRAINT roger_batch_pkey PRIMARY KEY (id);


--
-- Name: uniquecode_idx; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX uniquecode_idx ON public.uniquecode USING btree (buffered NULLS FIRST, productid, markingprinterid NULLS FIRST);


--
-- PostgreSQL database dump complete
--

