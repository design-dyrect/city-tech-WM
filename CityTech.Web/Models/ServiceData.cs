namespace CityTech.Web.Models;

public static class ServiceData
{
    private static readonly List<ServiceDetail> Services = new()
    {
        new ServiceDetail
        {
            Slug = "app-development",
            Title = "App Development",
            Summary = "We don’t just build apps. We help clients build the right apps, in the right way, for a maximum return on investment.",
            Details = "We don’t just build apps. We help clients build the right apps, in the right way, for a maximum return on investment. Throughout a holistic process that involves research, discovery, design, development and testing we give you the data you need to make decisions about what’s best for your business and provide the guidance you need along the way.<br/><br/>We help you understand tradeoffs, prioritise features, and deliver maximum functionality to your end-users, all while pushing toward long-term business objectives and satisfying short-term KPIs.<br/><br/>Our experience covers the development of native, cross-platform and hybrid mobile apps. By coming up with creative solutions to your most stringent requirements and offering you timely advice along the mobile development process, we maximise the business value we bring to the table.",
            Steps = new(),
            Receives = new()
            {
                new("Dedicated team",
                    "A team dedicated just for your project"),
                new("Secure and protected",
                    "The apps we create don't compromise data for design."),
                new("Full confidentiality",
                    "We will sign a NDA to protect your intellectual property."),
                new("Proven track record",
                    "Experience in delivering successfully to 4000+ projects."),
                new("Cost transformation",
                    "Align costs with strategy and focus on growth."),
                new("Many more",
                    "Many more benifits."),
            },
            Faqs = new(),
        },
        new ServiceDetail
        {
            Slug = "web-development",
            Title = "Web Development",
            Summary = "Web development consulting provides comprehensive support and enhancement of web applications before, during and after development.",
            Details = "Web development consulting provides comprehensive support and enhancement of web applications before, during and after development. City Tech consultants are skilled in gaining deep understanding of the client’s needs as well as finding the most beneficial and effective business solutions.<br/><br/>Your site brings people closer to you and we’ll help you shape their experience, utilising the skills of our in house experts as we are a specialist web development company. Working with you, our in-house team will develop high quality bespoke sites and applications that match the individual needs of your business.",
            Steps = new()
            {
                new("Client meeting & strategy",
                    "Define strategic goals for evolving your idea into a successfull app."),
                new("Analysis & Planning",
                    "Identify requirements, define team structure and prepare product roadmap."),
                new("UI/UX design",
                    "Create seamless and effortless user experiences with a polished design."),
                new("Web development",
                    "Develop backend API, database, web app, following agile development process."),
                new("Release & Testing",
                    "Do a release on cloud with staging and live environment, validate web app's quality thoroughly with a series of testing criteria."),
                new("Deployment & Support",
                    "Launch app on the cloud and support for future releases."),
            },
            Receives = new()
            {
                new("Dedicated team",
                    "A team dedicated just for your project"),
                new("Secure and protected",
                    "The apps we create don't compromise data for design."),
                new("Full confidentiality",
                    "We will sign a NDA to protect your intellectual property."),
                new("Proven track record",
                    "Experience in delivering successfully to 4000+ projects."),
                new("Cost transformation",
                    "Align costs with strategy and focus on growth."),
                new("Many more",
                    "Many more benifits."),
            },
            Faqs = new(),
        },
        new ServiceDetail
        {
            Slug = "cost-management",
            Title = "Cost Management",
            Summary = "A cost management service will allow clients to review comprehensive cost information reports which will help plan for future expenses and avoid budget overrun.",
            Details = "A cost management service will allow clients to review comprehensive cost information reports which will help plan for future expenses and avoid budget overrun. It gives a chance of a non-bias report from an 'outsider expert' like CTC to analyse and evaluate the CAPEX (capital expenses) and OPEX (operational expenses) and thereafter offering a solution that will allow to help resource planning, cost estimation, budgeting and full cost control without comprimising on productivity.",
            Steps = new()
            {
                new("Client meeting",
                    "A no-obligatory meeting to simply discuss and understand the business go-about, current industry & market information and most importantly the client requirements or objectives. Following this meeting CTC and the client will determine if a plan of action report will be required."),
                new("Presentation & Report",
                    "CTC will provide a plan of action report with a detailed presentation explaining the steps that would be taken to achieve their requirements or objectives. CTC fee, time-frame, action-deployment costs and expected financial savings will also be given in the report."),
                new("Execution",
                    "At this stage CTC will create a dedicated team which the actions that are agreed upon will start to be implemented."),
                new("Evaluation",
                    "CTC will evaluate the actions that were taken and provide a closing presentation and a written report."),
                new("Support & Service (optional)",
                    "Dependant on the closing report and the objectives that were set for cost management ongoing support & service will be offered on the client's discretion."),
            },
            Receives = new(),
            Faqs = new(),
        },
        new ServiceDetail
        {
            Slug = "maintainance-support",
            Title = "Maintenance & Support",
            Summary = null,
            Details = "Software maintenance is proactive and includes scheduled activities to address non-urgent issues or perform planned improvements. Software support is reactive and covers activities on handling urgent issues that can hamper software operation and cause downtimes. Most of our clients opt for both types to ensure stability, scalability, high performance, and robust security of software in the long run.<br/><br/>From the day your software system goes live, you'll be faced with the need to start supporting, maintaining, and properly \"evolving\" your application. Our IT support and maintenance services are designed to proactively handle the maintenance of software to ensure it is bug-free at deployment. We follow the best application software maintenance practices to make your software robust and secure.",
            Steps = new(),
            Receives = new(),
            Faqs = new(),
        },
        new ServiceDetail
        {
            Slug = "warranty-management",
            Title = "Warranty Management",
            Summary = "We help product brands manage warranties efficiently, cut operational costs, build stronger customer data and grow after-sales revenue.",
            Details = "Warranty management involves much more than processing a claim. When registration, claims, repairs and customer communication are spread across emails, spreadsheets and separate tools, they become difficult to track, slow to resolve and costly to manage.<br/><br/>We help brands bring all of this together in one place with Dyrect, a dedicated warranty management platform that more than 500 brands use to run their warranty operations. Customers can register products, check coverage and raise claims with ease. Brands can manage every claim from start to finish, track performance with real-time analytics, gain valuable customer data and grow after-sales revenue through extended warranty plans, protection plans and upsells.",
            Steps = new(),
            Receives = new()
            {
                new("One warranty system",
                    "Registrations, claims, repairs and replacements managed in a single platform."),
                new("Self-serve customer portal",
                    "Customers check coverage, file claims and track progress anytime."),
                new("Faster claims processing",
                    "Automatic eligibility checks using serial numbers and proof of purchase."),
                new("Customer data from every channel",
                    "Product registration through QR codes and your online store."),
                new("After-sales revenue",
                    "Extended warranty plans, protection plans and upsells at key moments."),
                new("Real-time analytics",
                    "Insights on claims, product issues, service performance and plan revenue."),
            },
            Faqs = new()
            {
                new("What do your warranty management services include?",
                    "Our services cover the full warranty programme, from process review and policy design to platform setup, integrations, team training and ongoing support."),
                new("Can brands capture customers who buy through marketplaces and retailers?",
                    "Yes. A QR code on the product or packaging lets customers register their warranty directly with the brand, wherever they bought the product."),
                new("Does it work with our existing tools?",
                    "Yes. The platform integrates with Shopify, WooCommerce, BigCommerce, HubSpot, Klaviyo, Zendesk, Freshdesk and Zoho Desk. Our developers can also build custom integrations through its API."),
                new("Can we offer extended warranty or protection plans?",
                    "Yes. We help you design and launch branded plans and offer them at checkout, during registration and after purchase."),
                new("How long does setup take?",
                    "Most programmes go live within a few weeks, depending on your products, sales channels and integrations."),
                new("Will the customer experience carry our branding?",
                    "Yes. Registration pages, warranty cards, emails and the customer portal all use your logo, colours and domain."),
            },
        },
    };

    public static ServiceDetail? Get(string slug) =>
        Services.FirstOrDefault(s => s.Slug == slug);
}
